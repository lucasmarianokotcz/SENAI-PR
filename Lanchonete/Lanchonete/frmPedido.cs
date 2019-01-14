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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            // Leitura do arquivo de licença em C:/Lanchonete/registro.cfg.
            try
            {
                // Lê o arquivo.
                using (StreamReader sr = new StreamReader("C:/Lanchonete/registro.cfg"))
                {
                    // Lê a primeira linha até o final e armazena numa string.
                    string licenca = sr.ReadToEnd();

                    // Se o texto do arquivo não for "sim", quer dizer que o software não está licenciado, então abre a tela de Licença.
                    if (licenca != "sim")
                    {
                        // Fecha StreamReader.
                        sr.Close();

                        frmLicenca frmLicenca = new frmLicenca();
                        frmLicenca.ShowDialog();
                    }
                }
            }
            // Erro ao ler arquivo de licença.
            catch (Exception)
            {
                MessageBox.Show("O arquivo de licença não pôde ser lido.", "Licença do produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa todos os campos do pedido.
            txtItem1.Clear();
            txtItem2.Clear();
            txtItem3.Clear();
            txtItem4.Clear();
            qtdItem1.Value = 0;
            qtdItem2.Value = 0;
            qtdItem3.Value = 0;
            qtdItem4.Value = 0;
            lblTotal.Text = "R$ 0,00";

            // Exibe o botão "Inserir pedido".
            btnInserirPedido.Visible = false;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            try
            {
                // Faz a soma dos valores do pedido.
                decimal total = Convert.ToDecimal(txtItem1.Text) * qtdItem1.Value +
                                Convert.ToDecimal(txtItem2.Text) * qtdItem2.Value +
                                Convert.ToDecimal(txtItem3.Text) * qtdItem3.Value +
                                Convert.ToDecimal(txtItem4.Text) * qtdItem4.Value;

                // Exibe o total do pedido.
                lblTotal.Text = "R$ " + string.Format("{0:#.00}", total);

                // Exibe o botão "Inserir pedido".
                btnInserirPedido.Visible = true;
            }
            catch (Exception)
            {
                // Informa ao usuário que ele não digitou os preços no formato correto.
                MessageBox.Show("Preço(s) em formato inválido. Digite somente números e apenas uma vírgula.", "Erro ao calcular total do pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Botões de MAIS (+) e MENOS (-)
        private void btnMaisItem1_Click(object sender, EventArgs e)
        {
            if (qtdItem1.Value < 100)
            {
                qtdItem1.Value = qtdItem1.Value + 1;
            }
        }        

        private void btnMaisItem2_Click(object sender, EventArgs e)
        {
            if (qtdItem2.Value < 100)
            {
                qtdItem2.Value = qtdItem2.Value + 1;
            }
        }

        private void btnMaisItem3_Click(object sender, EventArgs e)
        {
            if (qtdItem3.Value < 100)
            {
                qtdItem3.Value = qtdItem3.Value + 1;
            }
        }

        private void btnMaisItem4_Click(object sender, EventArgs e)
        {
            if (qtdItem4.Value < 100)
            {
                qtdItem4.Value = qtdItem4.Value + 1;
            }
        }

        private void btnMenosItem1_Click(object sender, EventArgs e)
        {
            if (qtdItem1.Value > 0)
            {
                qtdItem1.Value = qtdItem1.Value - 1;
            }
        }

        private void btnMenosItem2_Click(object sender, EventArgs e)
        {
            if (qtdItem2.Value > 0)
            {
                qtdItem2.Value = qtdItem2.Value - 1;
            }
        }

        private void btnMenosItem3_Click(object sender, EventArgs e)
        {
            if (qtdItem3.Value > 0)
            {
                qtdItem3.Value = qtdItem3.Value - 1;
            }
        }

        private void btnMenosItem4_Click(object sender, EventArgs e)
        {
            if (qtdItem4.Value > 0)
            {
                qtdItem4.Value = qtdItem4.Value - 1;
            }
        }
        #endregion

        private void btnInserirPedido_Click(object sender, EventArgs e)
        {
            try
            {
                PedidoBusiness pedidoBusiness = new PedidoBusiness();
                Pedido pedido = new Pedido
                {
                    Valor_pedido = Convert.ToDecimal(lblTotal.Text.Remove(0,3)),
                    Preco_cachorro_quente = Convert.ToDecimal(txtItem1.Text),
                    Qtd_cachorro_quente = Convert.ToInt32(qtdItem1.Value),
                    Preco_hamburger = Convert.ToDecimal(txtItem2.Text),
                    Qtd_hamburger = Convert.ToInt32(qtdItem2.Value),
                    Preco_refri_1l = Convert.ToDecimal(txtItem3.Text),
                    Qtd_refri_1l = Convert.ToInt32(qtdItem3.Value),
                    Preco_refri_2l = Convert.ToDecimal(txtItem4.Text),
                    Qtd_refri_2l = Convert.ToInt32(qtdItem4.Value)
                };

                // Insere o pedido no banco.
                pedidoBusiness.InserirPedido(pedido);
                MessageBox.Show("Pedido inserido com sucesso!", "Inserção de pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
