namespace VIEW
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tspUsuarioLogado = new System.Windows.Forms.StatusStrip();
            this.tspUsuarioLogadoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tabCliente_Imovel = new System.Windows.Forms.TabPage();
            this.btnExcluirImovel = new System.Windows.Forms.Button();
            this.btnAlterarImovel = new System.Windows.Forms.Button();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.btnPesquisaNome = new System.Windows.Forms.Button();
            this.btnPesquisaId = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.txtPesquisaId = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.dgvImoveis = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabCad_Cli = new System.Windows.Forms.TabPage();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.cmbEstadoCliente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComplementoCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDataNascCliente = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCidadeCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdCliente_Cliente = new System.Windows.Forms.TextBox();
            this.tabCad_Imo = new System.Windows.Forms.TabPage();
            this.btnCadastrarImovel = new System.Windows.Forms.Button();
            this.cmbEstadoImovel = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpDataAquisicaoImovel = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.txtValorImovel = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTipoImovel = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCidadeImovel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEnderecoImovel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdCliente_Imovel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ttpGeral = new System.Windows.Forms.ToolTip(this.components);
            this.tspUsuarioLogado.SuspendLayout();
            this.tbcPrincipal.SuspendLayout();
            this.tabCliente_Imovel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImoveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabCad_Cli.SuspendLayout();
            this.tabCad_Imo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspUsuarioLogado
            // 
            this.tspUsuarioLogado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspUsuarioLogadoLabel});
            this.tspUsuarioLogado.Location = new System.Drawing.Point(0, 539);
            this.tspUsuarioLogado.Name = "tspUsuarioLogado";
            this.tspUsuarioLogado.Size = new System.Drawing.Size(784, 22);
            this.tspUsuarioLogado.TabIndex = 0;
            this.tspUsuarioLogado.Text = "statusStrip1";
            // 
            // tspUsuarioLogadoLabel
            // 
            this.tspUsuarioLogadoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspUsuarioLogadoLabel.Name = "tspUsuarioLogadoLabel";
            this.tspUsuarioLogadoLabel.Size = new System.Drawing.Size(95, 17);
            this.tspUsuarioLogadoLabel.Text = "Usuário logado: ";
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tabCliente_Imovel);
            this.tbcPrincipal.Controls.Add(this.tabCad_Cli);
            this.tbcPrincipal.Controls.Add(this.tabCad_Imo);
            this.tbcPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(760, 524);
            this.tbcPrincipal.TabIndex = 1;
            // 
            // tabCliente_Imovel
            // 
            this.tabCliente_Imovel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabCliente_Imovel.Controls.Add(this.btnExcluirImovel);
            this.tabCliente_Imovel.Controls.Add(this.btnAlterarImovel);
            this.tabCliente_Imovel.Controls.Add(this.btnExcluirCliente);
            this.tabCliente_Imovel.Controls.Add(this.btnAlterarCliente);
            this.tabCliente_Imovel.Controls.Add(this.btnLimparPesquisa);
            this.tabCliente_Imovel.Controls.Add(this.btnPesquisaNome);
            this.tabCliente_Imovel.Controls.Add(this.btnPesquisaId);
            this.tabCliente_Imovel.Controls.Add(this.label23);
            this.tabCliente_Imovel.Controls.Add(this.txtPesquisaId);
            this.tabCliente_Imovel.Controls.Add(this.label22);
            this.tabCliente_Imovel.Controls.Add(this.txtPesquisaNome);
            this.tabCliente_Imovel.Controls.Add(this.dgvImoveis);
            this.tabCliente_Imovel.Controls.Add(this.label21);
            this.tabCliente_Imovel.Controls.Add(this.label20);
            this.tabCliente_Imovel.Controls.Add(this.dgvClientes);
            this.tabCliente_Imovel.Controls.Add(this.label2);
            this.tabCliente_Imovel.Location = new System.Drawing.Point(4, 22);
            this.tabCliente_Imovel.Name = "tabCliente_Imovel";
            this.tabCliente_Imovel.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente_Imovel.Size = new System.Drawing.Size(752, 498);
            this.tabCliente_Imovel.TabIndex = 2;
            this.tabCliente_Imovel.Text = "Clientes e Imóveis";
            // 
            // btnExcluirImovel
            // 
            this.btnExcluirImovel.Enabled = false;
            this.btnExcluirImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnExcluirImovel.Location = new System.Drawing.Point(615, 449);
            this.btnExcluirImovel.Name = "btnExcluirImovel";
            this.btnExcluirImovel.Size = new System.Drawing.Size(131, 43);
            this.btnExcluirImovel.TabIndex = 23;
            this.btnExcluirImovel.Text = "Excluir imóvel";
            this.btnExcluirImovel.UseVisualStyleBackColor = true;
            // 
            // btnAlterarImovel
            // 
            this.btnAlterarImovel.Enabled = false;
            this.btnAlterarImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAlterarImovel.Location = new System.Drawing.Point(429, 449);
            this.btnAlterarImovel.Name = "btnAlterarImovel";
            this.btnAlterarImovel.Size = new System.Drawing.Size(131, 43);
            this.btnAlterarImovel.TabIndex = 22;
            this.btnAlterarImovel.Text = "Alterar imóvel";
            this.btnAlterarImovel.UseVisualStyleBackColor = true;
            this.btnAlterarImovel.Click += new System.EventHandler(this.btnAlterarImovel_Click);
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnExcluirCliente.Location = new System.Drawing.Point(182, 449);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(131, 43);
            this.btnExcluirCliente.TabIndex = 21;
            this.btnExcluirCliente.Text = "Excluir cliente";
            this.btnExcluirCliente.UseVisualStyleBackColor = true;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAlterarCliente.Location = new System.Drawing.Point(6, 449);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(131, 43);
            this.btnAlterarCliente.TabIndex = 20;
            this.btnAlterarCliente.Text = "Alterar cliente";
            this.btnAlterarCliente.UseVisualStyleBackColor = true;
            this.btnAlterarCliente.Click += new System.EventHandler(this.btnAlterarCliente_Click);
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLimparPesquisa.Location = new System.Drawing.Point(292, 134);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(169, 26);
            this.btnLimparPesquisa.TabIndex = 19;
            this.btnLimparPesquisa.Text = "Limpar pesquisa";
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.btnLimparPesquisa_Click);
            // 
            // btnPesquisaNome
            // 
            this.btnPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnPesquisaNome.Location = new System.Drawing.Point(630, 77);
            this.btnPesquisaNome.Name = "btnPesquisaNome";
            this.btnPesquisaNome.Size = new System.Drawing.Size(93, 26);
            this.btnPesquisaNome.TabIndex = 3;
            this.btnPesquisaNome.Text = "Pesquisar";
            this.btnPesquisaNome.UseVisualStyleBackColor = true;
            this.btnPesquisaNome.Click += new System.EventHandler(this.btnPesquisaNome_Click);
            // 
            // btnPesquisaId
            // 
            this.btnPesquisaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnPesquisaId.Location = new System.Drawing.Point(216, 77);
            this.btnPesquisaId.Name = "btnPesquisaId";
            this.btnPesquisaId.Size = new System.Drawing.Size(97, 26);
            this.btnPesquisaId.TabIndex = 1;
            this.btnPesquisaId.Text = "Pesquisar";
            this.btnPesquisaId.UseVisualStyleBackColor = true;
            this.btnPesquisaId.Click += new System.EventHandler(this.btnPesquisaId_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(58, 80);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 20);
            this.label23.TabIndex = 18;
            this.label23.Text = "ID Cliente";
            // 
            // txtPesquisaId
            // 
            this.txtPesquisaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaId.Location = new System.Drawing.Point(143, 77);
            this.txtPesquisaId.MaxLength = 21;
            this.txtPesquisaId.Name = "txtPesquisaId";
            this.txtPesquisaId.Size = new System.Drawing.Size(67, 26);
            this.txtPesquisaId.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(372, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 20);
            this.label22.TabIndex = 16;
            this.label22.Text = "Nome";
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaNome.Location = new System.Drawing.Point(429, 77);
            this.txtPesquisaNome.MaxLength = 100;
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(195, 26);
            this.txtPesquisaNome.TabIndex = 2;
            // 
            // dgvImoveis
            // 
            this.dgvImoveis.AllowUserToAddRows = false;
            this.dgvImoveis.AllowUserToDeleteRows = false;
            this.dgvImoveis.AllowUserToResizeRows = false;
            this.dgvImoveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImoveis.Location = new System.Drawing.Point(6, 320);
            this.dgvImoveis.Name = "dgvImoveis";
            this.dgvImoveis.ReadOnly = true;
            this.dgvImoveis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImoveis.Size = new System.Drawing.Size(740, 123);
            this.dgvImoveis.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 292);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(206, 25);
            this.label21.TabIndex = 13;
            this.label21.Text = "Imóveis dos clientes";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 138);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 25);
            this.label20.TabIndex = 12;
            this.label20.Text = "Clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(6, 166);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(740, 123);
            this.dgvClientes.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pesquisa de clientes e imóveis";
            // 
            // tabCad_Cli
            // 
            this.tabCad_Cli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabCad_Cli.Controls.Add(this.txtTelefoneCliente);
            this.tabCad_Cli.Controls.Add(this.btnCadastrarCliente);
            this.tabCad_Cli.Controls.Add(this.cmbEstadoCliente);
            this.tabCad_Cli.Controls.Add(this.label8);
            this.tabCad_Cli.Controls.Add(this.txtComplementoCliente);
            this.tabCad_Cli.Controls.Add(this.label12);
            this.tabCad_Cli.Controls.Add(this.dtpDataNascCliente);
            this.tabCad_Cli.Controls.Add(this.label11);
            this.tabCad_Cli.Controls.Add(this.label10);
            this.tabCad_Cli.Controls.Add(this.label9);
            this.tabCad_Cli.Controls.Add(this.txtCidadeCliente);
            this.tabCad_Cli.Controls.Add(this.label7);
            this.tabCad_Cli.Controls.Add(this.txtEnderecoCliente);
            this.tabCad_Cli.Controls.Add(this.label6);
            this.tabCad_Cli.Controls.Add(this.txtEmailCliente);
            this.tabCad_Cli.Controls.Add(this.label5);
            this.tabCad_Cli.Controls.Add(this.txtNomeCliente);
            this.tabCad_Cli.Controls.Add(this.label4);
            this.tabCad_Cli.Controls.Add(this.label3);
            this.tabCad_Cli.Controls.Add(this.txtIdCliente_Cliente);
            this.tabCad_Cli.Location = new System.Drawing.Point(4, 22);
            this.tabCad_Cli.Name = "tabCad_Cli";
            this.tabCad_Cli.Padding = new System.Windows.Forms.Padding(3);
            this.tabCad_Cli.Size = new System.Drawing.Size(752, 498);
            this.tabCad_Cli.TabIndex = 0;
            this.tabCad_Cli.Text = "Cadastrar Cliente";
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneCliente.Location = new System.Drawing.Point(296, 302);
            this.txtTelefoneCliente.MaxLength = 11;
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(195, 26);
            this.txtTelefoneCliente.TabIndex = 7;
            this.txtTelefoneCliente.Enter += new System.EventHandler(this.txtTelefoneCliente_Enter);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCadastrarCliente.Location = new System.Drawing.Point(297, 439);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(159, 34);
            this.btnCadastrarCliente.TabIndex = 9;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // cmbEstadoCliente
            // 
            this.cmbEstadoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbEstadoCliente.FormattingEnabled = true;
            this.cmbEstadoCliente.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbEstadoCliente.Location = new System.Drawing.Point(297, 268);
            this.cmbEstadoCliente.MaxLength = 2;
            this.cmbEstadoCliente.Name = "cmbEstadoCliente";
            this.cmbEstadoCliente.Size = new System.Drawing.Size(67, 28);
            this.cmbEstadoCliente.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(110, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Complemento (opcional)";
            // 
            // txtComplementoCliente
            // 
            this.txtComplementoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplementoCliente.Location = new System.Drawing.Point(297, 204);
            this.txtComplementoCliente.MaxLength = 20;
            this.txtComplementoCliente.Name = "txtComplementoCliente";
            this.txtComplementoCliente.Size = new System.Drawing.Size(195, 26);
            this.txtComplementoCliente.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(139, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Data de nascimento";
            // 
            // dtpDataNascCliente
            // 
            this.dtpDataNascCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascCliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascCliente.Location = new System.Drawing.Point(297, 334);
            this.dtpDataNascCliente.Name = "dtpDataNascCliente";
            this.dtpDataNascCliente.Size = new System.Drawing.Size(195, 26);
            this.dtpDataNascCliente.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(221, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Telefone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(232, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(232, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cidade";
            // 
            // txtCidadeCliente
            // 
            this.txtCidadeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeCliente.Location = new System.Drawing.Point(297, 236);
            this.txtCidadeCliente.MaxLength = 45;
            this.txtCidadeCliente.Name = "txtCidadeCliente";
            this.txtCidadeCliente.Size = new System.Drawing.Size(195, 26);
            this.txtCidadeCliente.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Endereço";
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoCliente.Location = new System.Drawing.Point(297, 172);
            this.txtEnderecoCliente.MaxLength = 100;
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(195, 26);
            this.txtEnderecoCliente.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(238, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "E-mail";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.Location = new System.Drawing.Point(297, 140);
            this.txtEmailCliente.MaxLength = 100;
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(195, 26);
            this.txtEmailCliente.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nome";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(297, 108);
            this.txtNomeCliente.MaxLength = 100;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(195, 26);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cadastro de clientes";
            // 
            // txtIdCliente_Cliente
            // 
            this.txtIdCliente_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente_Cliente.Location = new System.Drawing.Point(297, 76);
            this.txtIdCliente_Cliente.MaxLength = 21;
            this.txtIdCliente_Cliente.Name = "txtIdCliente_Cliente";
            this.txtIdCliente_Cliente.ReadOnly = true;
            this.txtIdCliente_Cliente.Size = new System.Drawing.Size(67, 26);
            this.txtIdCliente_Cliente.TabIndex = 0;
            // 
            // tabCad_Imo
            // 
            this.tabCad_Imo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabCad_Imo.Controls.Add(this.btnCadastrarImovel);
            this.tabCad_Imo.Controls.Add(this.cmbEstadoImovel);
            this.tabCad_Imo.Controls.Add(this.label19);
            this.tabCad_Imo.Controls.Add(this.dtpDataAquisicaoImovel);
            this.tabCad_Imo.Controls.Add(this.label18);
            this.tabCad_Imo.Controls.Add(this.txtValorImovel);
            this.tabCad_Imo.Controls.Add(this.label17);
            this.tabCad_Imo.Controls.Add(this.txtTipoImovel);
            this.tabCad_Imo.Controls.Add(this.label16);
            this.tabCad_Imo.Controls.Add(this.label15);
            this.tabCad_Imo.Controls.Add(this.txtCidadeImovel);
            this.tabCad_Imo.Controls.Add(this.label14);
            this.tabCad_Imo.Controls.Add(this.txtEnderecoImovel);
            this.tabCad_Imo.Controls.Add(this.label13);
            this.tabCad_Imo.Controls.Add(this.txtIdCliente_Imovel);
            this.tabCad_Imo.Controls.Add(this.label1);
            this.tabCad_Imo.Location = new System.Drawing.Point(4, 22);
            this.tabCad_Imo.Name = "tabCad_Imo";
            this.tabCad_Imo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCad_Imo.Size = new System.Drawing.Size(752, 498);
            this.tabCad_Imo.TabIndex = 1;
            this.tabCad_Imo.Text = "Cadastrar Imóvel";
            // 
            // btnCadastrarImovel
            // 
            this.btnCadastrarImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCadastrarImovel.Location = new System.Drawing.Point(297, 439);
            this.btnCadastrarImovel.Name = "btnCadastrarImovel";
            this.btnCadastrarImovel.Size = new System.Drawing.Size(159, 34);
            this.btnCadastrarImovel.TabIndex = 7;
            this.btnCadastrarImovel.Text = "Cadastrar";
            this.btnCadastrarImovel.UseVisualStyleBackColor = true;
            this.btnCadastrarImovel.Click += new System.EventHandler(this.btnCadastrarImovel_Click);
            // 
            // cmbEstadoImovel
            // 
            this.cmbEstadoImovel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbEstadoImovel.FormattingEnabled = true;
            this.cmbEstadoImovel.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbEstadoImovel.Location = new System.Drawing.Point(297, 172);
            this.cmbEstadoImovel.MaxLength = 2;
            this.cmbEstadoImovel.Name = "cmbEstadoImovel";
            this.cmbEstadoImovel.Size = new System.Drawing.Size(67, 28);
            this.cmbEstadoImovel.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(154, 275);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 20);
            this.label19.TabIndex = 27;
            this.label19.Text = "Data de aquisição";
            // 
            // dtpDataAquisicaoImovel
            // 
            this.dtpDataAquisicaoImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataAquisicaoImovel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAquisicaoImovel.Location = new System.Drawing.Point(297, 270);
            this.dtpDataAquisicaoImovel.Name = "dtpDataAquisicaoImovel";
            this.dtpDataAquisicaoImovel.Size = new System.Drawing.Size(195, 26);
            this.dtpDataAquisicaoImovel.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(124, 241);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 20);
            this.label18.TabIndex = 25;
            this.label18.Text = "Valor do imóvel em R$";
            // 
            // txtValorImovel
            // 
            this.txtValorImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorImovel.Location = new System.Drawing.Point(297, 238);
            this.txtValorImovel.MaxLength = 13;
            this.txtValorImovel.Name = "txtValorImovel";
            this.txtValorImovel.Size = new System.Drawing.Size(195, 26);
            this.txtValorImovel.TabIndex = 5;
            this.txtValorImovel.Enter += new System.EventHandler(this.txtValorImovel_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(79, 209);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(212, 20);
            this.label17.TabIndex = 23;
            this.label17.Text = "Tipo (casa, apartamento etc)";
            // 
            // txtTipoImovel
            // 
            this.txtTipoImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoImovel.Location = new System.Drawing.Point(297, 206);
            this.txtTipoImovel.MaxLength = 20;
            this.txtTipoImovel.Name = "txtTipoImovel";
            this.txtTipoImovel.Size = new System.Drawing.Size(195, 26);
            this.txtTipoImovel.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(231, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "Estado";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(232, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "Cidade";
            // 
            // txtCidadeImovel
            // 
            this.txtCidadeImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeImovel.Location = new System.Drawing.Point(297, 140);
            this.txtCidadeImovel.MaxLength = 45;
            this.txtCidadeImovel.Name = "txtCidadeImovel";
            this.txtCidadeImovel.Size = new System.Drawing.Size(195, 26);
            this.txtCidadeImovel.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(213, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "Endereço";
            // 
            // txtEnderecoImovel
            // 
            this.txtEnderecoImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoImovel.Location = new System.Drawing.Point(297, 108);
            this.txtEnderecoImovel.MaxLength = 100;
            this.txtEnderecoImovel.Name = "txtEnderecoImovel";
            this.txtEnderecoImovel.Size = new System.Drawing.Size(195, 26);
            this.txtEnderecoImovel.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(212, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "ID Cliente";
            // 
            // txtIdCliente_Imovel
            // 
            this.txtIdCliente_Imovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente_Imovel.Location = new System.Drawing.Point(297, 76);
            this.txtIdCliente_Imovel.MaxLength = 21;
            this.txtIdCliente_Imovel.Name = "txtIdCliente_Imovel";
            this.txtIdCliente_Imovel.Size = new System.Drawing.Size(67, 26);
            this.txtIdCliente_Imovel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cadastro de imóveis";
            // 
            // ttpGeral
            // 
            this.ttpGeral.IsBalloon = true;
            this.ttpGeral.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tbcPrincipal);
            this.Controls.Add(this.tspUsuarioLogado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal - Imobiliária";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tspUsuarioLogado.ResumeLayout(false);
            this.tspUsuarioLogado.PerformLayout();
            this.tbcPrincipal.ResumeLayout(false);
            this.tabCliente_Imovel.ResumeLayout(false);
            this.tabCliente_Imovel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImoveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabCad_Cli.ResumeLayout(false);
            this.tabCad_Cli.PerformLayout();
            this.tabCad_Imo.ResumeLayout(false);
            this.tabCad_Imo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip tspUsuarioLogado;
        private System.Windows.Forms.ToolStripStatusLabel tspUsuarioLogadoLabel;
        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tabCad_Cli;
        private System.Windows.Forms.TabPage tabCad_Imo;
        private System.Windows.Forms.TabPage tabCliente_Imovel;
        private System.Windows.Forms.TextBox txtIdCliente_Cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCidadeCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEnderecoCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.DateTimePicker dtpDataNascCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComplementoCliente;
        private System.Windows.Forms.ComboBox cmbEstadoCliente;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEnderecoImovel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIdCliente_Imovel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpDataAquisicaoImovel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTipoImovel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCidadeImovel;
        private System.Windows.Forms.ComboBox cmbEstadoImovel;
        private System.Windows.Forms.Button btnCadastrarImovel;
        private System.Windows.Forms.TextBox txtTelefoneCliente;
        private System.Windows.Forms.TextBox txtValorImovel;
        private System.Windows.Forms.ToolTip ttpGeral;
        private System.Windows.Forms.DataGridView dgvImoveis;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtPesquisaId;
        private System.Windows.Forms.Button btnPesquisaNome;
        private System.Windows.Forms.Button btnPesquisaId;
        private System.Windows.Forms.Button btnLimparPesquisa;
        private System.Windows.Forms.Button btnExcluirImovel;
        private System.Windows.Forms.Button btnAlterarImovel;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Button btnAlterarCliente;
    }
}