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
using System.Text.RegularExpressions;

namespace VIEW
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public frmPrincipal(string usuario)
        {
            InitializeComponent();
            tspUsuarioLogadoLabel.Text += usuario;
        }

        #region Validação Cliente
        // Verifica campos vazios do cadastro de cliente.
        public bool VerificaCamposVazios_Cliente()
        {
            // Varre os controles da aba Cliente.
            foreach (Control item in tabCad_Cli.Controls)
            {
                // Se o texto do controle é nulo ou tem espaço em branco, acusa erro de campo vazio.
                if (string.IsNullOrWhiteSpace(item.Text))
                {
                    // Se o nome do controle que está sendo varrido é ID Cliente ou Complemento (opcional), pule pro próximo controle.
                    if (item.Name == txtIdCliente_Cliente.Name || item.Name == txtComplementoCliente.Name)
                    {
                        continue;
                    }
                    MessageBox.Show("Verifique campos vazios!", "Erro ao cadastrar imóvel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Caampos inválidos. Algum deles está vazio.
                    return false;
                }
            }
            // Campos validados (não estão vazios).
            return true;
        }

        // Valida campos Nome, E-mail e Telefone do cadastro de cliente.
        public bool ValidarCampos_Cliente()
        {
            string erro = "";

            // Verifica se campo Nome tem números.
            if (Regex.IsMatch(txtNomeCliente.Text, "^[0-9]"))
            {
                erro += "Campo Nome não possui um formato válido.\n";
            }

            // Verifica se campo E-mail começa com número, não contém @ ou não contém pelo menos um . depois do @.
            if (Regex.IsMatch(txtEmailCliente.Text.Substring(0, 1), "^[0-9]") || !txtEmailCliente.Text.Contains("@") || txtEmailCliente.Text.LastIndexOf(".") < txtEmailCliente.Text.LastIndexOf("@"))
            {
                erro += "Campo E-mail não possui um formato válido.\n";
            }

            // Verifica se campo Telefone não possui nada além de números.
            if (!Regex.IsMatch(txtTelefoneCliente.Text, @"^[0-9]+$"))
            {
                erro += "Campo Telefone não possui um formato válido.";
            }

            if (string.IsNullOrEmpty(erro))
            {
                // Campos validados.
                return true;
            }
            else
            {
                MessageBox.Show(erro, "Erro ao cadastrar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Campos inválidos.
                return false;
            }
        }
        #endregion

        #region Validação Imóvel
        // Verifica campos vazios do cadastro de imóvel.
        public bool VerificaCamposVazios_Imovel()
        {
            // Varre os controles da aba Imóvel.
            foreach (Control item in tabCad_Imo.Controls)
            {
                // Se o texto do controle é nulo ou tem espaço em branco, acusa erro de campo vazio.
                if (string.IsNullOrWhiteSpace(item.Text))
                {
                    MessageBox.Show("Verifique campos vazios!", "Erro ao cadastrar imóvel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Caampos inválidos. Algum deles está vazio.
                    return false;
                }
            }
            // Campos validados (não estão vazios).
            return true;
        }

        // Valida campos ID Cliente e Valor do cadastro de imóvel.
        public bool ValidarCampos_Imovel()
        {
            string erro = "";

            // Verifica se campo ID Cliente não possui nada além de números.
            if (!Regex.IsMatch(txtIdCliente_Imovel.Text, @"^[0-9]+$"))
            {
                erro += "Campo ID Cliente não possui um formato válido.\n";
                txtIdCliente_Imovel.SelectAll();
                txtIdCliente_Imovel.Focus();
            }

            // Verifica se campo Valor possui vírgula e 2 casas depois dela.
            decimal valor;
            decimal.TryParse(txtValorImovel.Text, out valor);
            if (!(txtValorImovel.Text == String.Format("{0:0.00}", valor)))
            {
                erro += "Campo Valor não possui um formato válido.";
                txtValorImovel.SelectAll();
                txtValorImovel.Focus();
            }

            if (string.IsNullOrEmpty(erro))
            {
                // Campos validados.
                return true;
            }
            else
            {
                MessageBox.Show(erro, "Erro ao cadastrar imóvel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Campos inválidos.
                return false;
            }
        }
        #endregion        

        #region Cadastrar Cliente
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            string status = btnCadastrarCliente.Text;
            switch (status)
            {
                case "Cadastrar":
                    if (VerificaCamposVazios_Cliente() && ValidarCampos_Cliente())
                    {
                        // Envia os dados dos campos para o cadastro do cliente.
                        ClienteBusiness clienteBusiness = new ClienteBusiness();
                        Cliente cliente = new Cliente
                        {
                            Nome = txtNomeCliente.Text,
                            Email = txtEmailCliente.Text,
                            Endereco = txtEnderecoCliente.Text,
                            Complemento = txtComplementoCliente.Text,
                            Cidade = txtCidadeCliente.Text,
                            Estado = cmbEstadoCliente.Text,
                            Telefone = txtTelefoneCliente.Text,
                            Data_nasc = dtpDataNascCliente.Value
                        };

                        clienteBusiness.Inserir(cliente);
                        MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpa os campos para novo cadastro de cliente.
                        txtNomeCliente.Clear();
                        txtEmailCliente.Clear();
                        txtEnderecoCliente.Clear();
                        txtComplementoCliente.Clear();
                        txtCidadeCliente.Clear();
                        cmbEstadoCliente.SelectedIndex = -1;
                        txtTelefoneCliente.Clear();
                        dtpDataNascCliente.Value = DateTime.Now;
                        txtNomeCliente.Focus();

                        // Carrega no DataGridView os clientes.
                        CarregarDadosCliente();
                    }
                    break;

                case "Alterar":
                    if (VerificaCamposVazios_Cliente() && ValidarCampos_Cliente())
                    {
                        // Envia os dados dos campos para a alteração dos dados do cliente.
                        ClienteBusiness clienteBusiness = new ClienteBusiness();
                        Cliente cliente = new Cliente
                        {
                            Id_cliente = Convert.ToInt32(txtIdCliente_Cliente.Text),
                            Nome = txtNomeCliente.Text,
                            Email = txtEmailCliente.Text,
                            Endereco = txtEnderecoCliente.Text,
                            Complemento = txtComplementoCliente.Text,
                            Cidade = txtCidadeCliente.Text,
                            Estado = cmbEstadoCliente.Text,
                            Telefone = txtTelefoneCliente.Text,
                            Data_nasc = dtpDataNascCliente.Value
                        };

                        clienteBusiness.Alterar(cliente);
                        MessageBox.Show("Cliente alterado com sucesso!", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpa os campos para novo cadastro de cliente.
                        txtIdCliente_Cliente.Clear();
                        txtNomeCliente.Clear();
                        txtEmailCliente.Clear();
                        txtEnderecoCliente.Clear();
                        txtComplementoCliente.Clear();
                        txtCidadeCliente.Clear();
                        cmbEstadoCliente.SelectedIndex = -1;
                        txtTelefoneCliente.Clear();
                        dtpDataNascCliente.Value = DateTime.Now;

                        // Carrega no DataGridView os clientes.
                        CarregarDadosCliente();
                        tbcPrincipal.SelectedIndex = 0;
                        btnCadastrarCliente.Text = "Cadastrar";
                    }
                    break;

                default:
                    break;
            }
        }
        #endregion

        #region Cadastrar Imóvel
        private void btnCadastrarImovel_Click(object sender, EventArgs e)
        {
            string status = btnCadastrarImovel.Text;
            switch (status)
            {
                case "Cadastrar":
                    if (VerificaCamposVazios_Imovel() && ValidarCampos_Imovel())
                    {
                        // Envia os dados dos campos para o cadastro do imóvel do cliente.  
                        Cliente cliente = new Cliente();
                        cliente.Id_cliente = Convert.ToInt32(txtIdCliente_Imovel.Text);

                        ImovelBusiness imovelBusiness = new ImovelBusiness();
                        Imovel imovel = new Imovel
                        {
                            Cliente = cliente,
                            Endereco = txtEnderecoImovel.Text,
                            Cidade = txtCidadeImovel.Text,
                            Estado = cmbEstadoImovel.Text,
                            Tipo = txtTipoImovel.Text,
                            Valor = Convert.ToDecimal(txtValorImovel.Text),
                            Data_aquisicao = dtpDataAquisicaoImovel.Value
                        };

                        try
                        {
                            imovelBusiness.Inserir(imovel);
                            MessageBox.Show("Imóvel cadastrado com sucesso!", "Cadastro de imóvel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Limpa os campos para novo cadastro de imóvel do cliente.
                            txtIdCliente_Imovel.Clear();
                            txtEnderecoImovel.Clear();
                            txtCidadeImovel.Clear();
                            cmbEstadoImovel.SelectedIndex = -1;
                            txtTipoImovel.Clear();
                            txtValorImovel.Clear();
                            dtpDataAquisicaoImovel.Value = DateTime.Now;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Cliente não cadastrado.", "Erro ao cadastrar imóvel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtIdCliente_Imovel.SelectAll();
                            txtIdCliente_Imovel.Focus();
                        }
                    }
                    break;

                case "Alterar":
                    if (VerificaCamposVazios_Imovel() && ValidarCampos_Imovel())
                    {
                        // Envia os dados dos campos para o cadastro do imóvel do cliente.  
                        Cliente cliente = new Cliente();
                        cliente.Id_cliente = Convert.ToInt32(txtIdCliente_Imovel.Text);

                        ImovelBusiness imovelBusiness = new ImovelBusiness();
                        Imovel imovel = new Imovel
                        {
                            Cliente = cliente,
                            Endereco = txtEnderecoImovel.Text,
                            Cidade = txtCidadeImovel.Text,
                            Estado = cmbEstadoImovel.Text,
                            Tipo = txtTipoImovel.Text,
                            Valor = Convert.ToDecimal(txtValorImovel.Text),
                            Data_aquisicao = dtpDataAquisicaoImovel.Value
                        };

                        try
                        {
                            imovelBusiness.Alterar(imovel);
                            MessageBox.Show("Imóvel alterado com sucesso!", "Alteração de imóvel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Limpa os campos para novo cadastro de imóvel do cliente.
                            txtIdCliente_Imovel.Clear();
                            txtEnderecoImovel.Clear();
                            txtCidadeImovel.Clear();
                            cmbEstadoImovel.SelectedIndex = -1;
                            txtTipoImovel.Clear();
                            txtValorImovel.Clear();
                            dtpDataAquisicaoImovel.Value = DateTime.Now;
                            tbcPrincipal.SelectedIndex = 0;
                            btnCadastrarImovel.Text = "Cadastrar";
                            dgvImoveis.DataSource = null;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Cliente não cadastrado.", "Erro ao alterar imóvel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtIdCliente_Imovel.SelectAll();
                            txtIdCliente_Imovel.Focus();
                        }
                    }
                    break;

                default:
                    break;
            }

        }
        #endregion

        #region Pesquisa por ID
        private void btnPesquisaId_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteBusiness clienteBusiness = new ClienteBusiness();
                Cliente cliente = new Cliente();
                cliente.Id_cliente = Convert.ToInt32(txtPesquisaId.Text);

                // Variável para determinar qual DataGridView será preenchido.
                bool vezDoCliente = true;

                // Preenche o DataGridView do Cliente.
                dgvClientes.DataSource = clienteBusiness.BuscarClientePorId(cliente, vezDoCliente);

                // Preenche o DataGridView dos Imoveis do Cliente.
                vezDoCliente = false;
                dgvImoveis.DataSource = clienteBusiness.BuscarClientePorId(cliente, vezDoCliente);
            }
            catch (Exception)
            {
                MessageBox.Show("Digite corretamente o ID do Cliente.", "Erro ao buscar por ID do Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPesquisaId.SelectAll();
                txtPesquisaId.Focus();
            }

        }
        #endregion

        #region Pesquisa por Nome
        private void btnPesquisaNome_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteBusiness clienteBusiness = new ClienteBusiness();
                Cliente cliente = new Cliente();
                cliente.Nome = txtPesquisaNome.Text;

                // Variável para determinar qual DataGridView será preenchido.
                bool vezDoCliente = true;

                // Preenche o DataGridView do Cliente.
                dgvClientes.DataSource = clienteBusiness.BuscarClientePorNome(cliente, vezDoCliente);

                // Pega o ID do primeiro cliente encontrado pelo nome.
                cliente.Id_cliente = Convert.ToInt32(dgvClientes[0, 0].Value);

                // Preenche o DataGridView dos Imoveis do Cliente.
                vezDoCliente = false;
                dgvImoveis.DataSource = clienteBusiness.BuscarClientePorNome(cliente, vezDoCliente);
            }
            catch (Exception)
            {
                MessageBox.Show("Digite corretamente o Nome do Cliente.", "Erro ao buscar por Nome do Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPesquisaNome.SelectAll();
                txtPesquisaNome.Focus();
            }
        }
        #endregion

        #region Alterar Cliente
        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                // Pega a linha atual selecionada.
                int linhaAtual = dgvClientes.CurrentRow.Index;

                // Manda para a aba 'Cadastro de Clientes' os dados do DataGridView da linha selecionada.
                txtIdCliente_Cliente.Text = dgvClientes[0, linhaAtual].Value.ToString();
                txtNomeCliente.Text = dgvClientes[1, linhaAtual].Value.ToString();
                txtEmailCliente.Text = dgvClientes[2, linhaAtual].Value.ToString();
                txtEnderecoCliente.Text = dgvClientes[3, linhaAtual].Value.ToString();
                txtComplementoCliente.Text = dgvClientes[4, linhaAtual].Value.ToString();
                txtCidadeCliente.Text = dgvClientes[5, linhaAtual].Value.ToString();
                cmbEstadoCliente.Text = dgvClientes[6, linhaAtual].Value.ToString();
                txtTelefoneCliente.Text = dgvClientes[7, linhaAtual].Value.ToString();
                dtpDataNascCliente.Text = dgvClientes[8, linhaAtual].Value.ToString();

                btnCadastrarCliente.Text = "Alterar";
                tbcPrincipal.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Selecione um Cliente para alterar.", "Erro ao alterar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Excluir Cliente
        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir o Cliente selecionado e seus imóveis?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    // Pega a linha atual selecionada.
                    int linhaAtual = dgvClientes.CurrentRow.Index;

                    // Cria um objeto da linha selecionada a partir da linha atual selecionada do DataGridView.
                    DataGridViewRow linhaSelecionada = dgvClientes.Rows[linhaAtual];

                    // Pega o ID do Cliente selecionado.
                    int idCliente = Convert.ToInt32(linhaSelecionada.Cells["ID_CLIENTE"].Value);

                    // Passa para o Business o ID do Cliente para exclusão.
                    ClienteBusiness clienteBusiness = new ClienteBusiness();
                    Cliente cliente = new Cliente();
                    cliente.Id_cliente = idCliente;

                    // Bool para excluir primeiro os imóveis do cliente e depois o cliente. 'true' indica que está sendo excluído os imóveis. 'false' indica que está sendo excluído o cliente selecionado.
                    bool vezDoImovel = true;
                    clienteBusiness.Excluir(cliente, vezDoImovel);

                    vezDoImovel = false;
                    clienteBusiness.Excluir(cliente, vezDoImovel);

                    // Carrega no DataGridView os clientes.
                    CarregarDadosCliente();
                    MessageBox.Show("Cliente excluído com sucesso!", "Exclusão de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvImoveis.DataSource = null;

                    // Limpa os campos para novo cadastro de cliente.
                    txtIdCliente_Cliente.Clear();
                    txtNomeCliente.Clear();
                    txtEmailCliente.Clear();
                    txtEnderecoCliente.Clear();
                    txtComplementoCliente.Clear();
                    txtCidadeCliente.Clear();
                    cmbEstadoCliente.SelectedIndex = -1;
                    txtTelefoneCliente.Clear();
                    dtpDataNascCliente.Value = DateTime.Now;
                    btnCadastrarCliente.Text = "Cadastrar";
                }
            }
            else
            {
                MessageBox.Show("Selecione um Cliente para excluir.", "Erro ao excluir Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        // Método para carregar dados do Cliente no DataGridView.
        public void CarregarDadosCliente()
        {
            ClienteBusiness clienteBusiness = new ClienteBusiness();
            dgvClientes.DataSource = clienteBusiness.CarregarDadosCliente();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Quer realmente sair?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void txtValorImovel_Enter(object sender, EventArgs e)
        {
            ttpGeral.ToolTipTitle = "Somente números e vírgula";
            ttpGeral.Show("Exemplo de formato válido: 99999,99", txtValorImovel, 150, -60, 2500);
        }

        private void txtTelefoneCliente_Enter(object sender, EventArgs e)
        {
            ttpGeral.ToolTipTitle = "Somente números";
            ttpGeral.Show("Exemplo de telefone válido: 11988887777", txtTelefoneCliente, 150, -60, 2500);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CarregarDadosCliente();
        }

        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            CarregarDadosCliente();
            txtPesquisaId.Clear();
            txtPesquisaNome.Clear();
            dgvImoveis.DataSource = null;
        }

        private void btnAlterarImovel_Click(object sender, EventArgs e)
        {
            if (dgvImoveis.SelectedRows.Count == 1)
            {
                // Pega a linha atual selecionada.
                int linhaAtual = dgvImoveis.CurrentRow.Index;

                // Manda para a aba 'Cadastro de Imoveis' os dados do DataGridView da linha selecionada.
                txtIdCliente_Imovel.Text = dgvImoveis[0, linhaAtual].Value.ToString();
                txtEnderecoImovel.Text = dgvImoveis[1, linhaAtual].Value.ToString();
                txtCidadeImovel.Text = dgvImoveis[2, linhaAtual].Value.ToString();
                cmbEstadoImovel.Text = dgvImoveis[3, linhaAtual].Value.ToString();
                txtTipoImovel.Text = dgvImoveis[4, linhaAtual].Value.ToString();
                txtValorImovel.Text = dgvImoveis[5, linhaAtual].Value.ToString();
                dtpDataAquisicaoImovel.Text = dgvImoveis[6, linhaAtual].Value.ToString();

                btnCadastrarImovel.Text = "Alterar";
                tbcPrincipal.SelectedIndex = 2;
            }
            else
            {
                MessageBox.Show("Selecione um Imóvel para alterar.", "Erro ao alterar Imóvel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
