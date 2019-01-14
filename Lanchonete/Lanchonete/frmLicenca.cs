using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSINESS;
using MODEL;
using System.IO;

namespace Lanchonete
{
    public partial class frmLicenca : Form
    {
        // Motivo do fechamento da aplicação (usuário ou ativação do software).
        public static class MotivoFechamento
        {
            public static string motivo = "usuário";
        }

        public frmLicenca()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Pega a licença digitada pelo usuário atráves do TextBox e envia ao objeto da classe Registro.
                Registro registro = new Registro();
                registro.Cod_registro = txtLicenca.Text;

                // Busca no banco a licença digitada pelo usuário.
                RegistroBusiness registroBusiness = new RegistroBusiness();
                DataTable dtLicenca = registroBusiness.VerifChave(registro);

                // Verifica se a licença digitada pelo usuário existe no BD (se a contagem de linhas do DataTable for 1 quer dizer que o código de licença existe no BD).
                if (dtLicenca.Rows.Count == 1)
                {
                    // Verifica se a licença já foi utilizada. False quer dizer que a licença não foi utilizada. True significa que a licença já foi utilizada anteriormente.
                    if (dtLicenca.Rows[0][0].ToString() == "False")
                    {
                        try
                        {
                            // Atualiza o arquivo registro.cfg para marcar que o software foi ativado com sucesso.
                            string licenca = File.ReadAllText("C:/Lanchonete/registro.cfg");
                            licenca = licenca.Replace("nao", "sim");
                            File.WriteAllText("C:/Lanchonete/registro.cfg", licenca);

                            // Envia o código do registro para ser atualizado o status no BD (de "não ativado" para "produto ativado").
                            registroBusiness.AtualizarRegistro(registro);

                            MessageBox.Show("Produto ativado com sucesso!", "Produto ativado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MotivoFechamento.motivo = "ativação";
                            Close();
                        }
                        // Não conseguiu ler o arquivo ou conectar ao banco de dados.
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message, "Licença do produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    // Licença já foi utilizada por outro usuário.
                    else
                    {
                        MessageBox.Show("Chave de licença já foi utilizada ou não existe.", "Erro ao ativar produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Não foi encontrado no banco de dados o código digitado pelo usuário.
                else
                {
                    MessageBox.Show("Chave de licença já foi utilizada ou não existe.", "Erro ao ativar produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Falha na conexão com BD.
            catch (Exception)
            {
                MessageBox.Show("Não foi possível verificar a sua licença do produto.", "Erro ao validar licença", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLicenca_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MotivoFechamento.motivo == "usuário")
            {
                Application.Exit();
            }
        }
    }
}
