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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            // Cria objetos das classes para verificação de login.
            AdminBusiness adminBusiness = new AdminBusiness();
            Admin admin = new Admin
            {

                // Envia ao objeto 'admin' da classe Admin os textos digitados no form.
                Login = txtLogin.Text,
                Senha = txtSenha.Text
            };

            // Cria um DataTable que busca o login no banco.
            DataTable dt = adminBusiness.BuscarUsuario(admin);

            // Verifica se foi retornado algum valor (1 linha) para o DataTable 'dt'. Se sim, validou usuário e senha.
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Logado com sucesso!", "Login efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                frmPrincipal frmPrincipal = new frmPrincipal(txtLogin.Text);
                frmPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!", "Erro no login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.SelectAll();
                txtLogin.Focus();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.ShowDialog();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogar_Click(null, null);
            }
            else if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogar_Click(null, null);
            }
            else if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
