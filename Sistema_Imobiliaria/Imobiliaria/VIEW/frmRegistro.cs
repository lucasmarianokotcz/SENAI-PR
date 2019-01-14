using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;
using BUSINESS;

namespace VIEW
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        // Verifica se usuário e senha de cadastro possuem pelo menos 4 caracteres.
        public bool VerificaCampos()
        {
            string erro = "";
            if (txtLogin.Text.Length < 4)
            {
                erro += "Nome de usuário deve conter pelo menos 4 dígitos.\n";
                txtLogin.SelectAll();
                txtLogin.Focus();
            }
            if (txtSenha.Text.Length < 4)
            {
                erro += "Sua senha deve conter pelo menos 4 dígitos.";
                txtSenha.SelectAll();
                txtSenha.Focus();
            }

            // Se 'erro' tiver algum conteúdo na string, ou seja, se foi detectado algum erro nos campos, mostra ao usuário o erro.
            if (!string.IsNullOrEmpty(erro))
            {
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Retorna true caso não foi detectado nenhum erro do cadastro de novo usuário.
            return true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos estão válidos para cadastro de usuário. Caso retorne true, estão válidos.
            if (VerificaCampos())
            {
                // Cria objetos das classes para verificação de login.
                AdminBusiness adminBusiness = new AdminBusiness();
                Admin admin = new Admin
                {
                    // Envia ao objeto 'admin' da classe Admin o texto digitado no form (txtLogin).
                    Login = txtLogin.Text,
                    Senha = txtSenha.Text
                };

                // Cria um DataTable que busca o login no banco.
                DataTable dt = adminBusiness.BuscarLogin(admin);

                // Verifica se já foi encontrado um usuário com o mesmo login. Se não foi, cadastra novo usuário.
                if (dt.Rows.Count == 0)
                {
                    adminBusiness.CadastrarUsuario(admin);
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Login efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Nome de usuário já existe!", "Erro no login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.SelectAll();
                    txtLogin.Focus();
                }
            }        
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
