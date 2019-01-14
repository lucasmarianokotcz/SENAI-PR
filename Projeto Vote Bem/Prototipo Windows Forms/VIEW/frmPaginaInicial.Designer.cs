namespace VIEW
{
    partial class frmPaginaInicial
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
            this.panelPaginaInicial = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbIdade = new System.Windows.Forms.ComboBox();
            this.panelVoteBem = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelQuiz = new System.Windows.Forms.Panel();
            this.btnProximaPergunta = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPerguntaAtual = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.picResposta2 = new System.Windows.Forms.PictureBox();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.rbResposta2 = new System.Windows.Forms.RadioButton();
            this.picResposta1 = new System.Windows.Forms.PictureBox();
            this.rbResposta1 = new System.Windows.Forms.RadioButton();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblEmailEnviado = new System.Windows.Forms.Label();
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.lblCodigoPesquisa = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelPaginaInicial.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelVoteBem.SuspendLayout();
            this.panelQuiz.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResposta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResposta1)).BeginInit();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPaginaInicial
            // 
            this.panelPaginaInicial.Controls.Add(this.groupBox2);
            this.panelPaginaInicial.Controls.Add(this.groupBox1);
            this.panelPaginaInicial.Location = new System.Drawing.Point(12, 12);
            this.panelPaginaInicial.Name = "panelPaginaInicial";
            this.panelPaginaInicial.Size = new System.Drawing.Size(1240, 657);
            this.panelPaginaInicial.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPesquisa);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(657, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 120);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visualizar resultado de jogo anterior";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPesquisa.Location = new System.Drawing.Point(13, 46);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(374, 38);
            this.txtPesquisa.TabIndex = 4;
            this.txtPesquisa.Text = "Digite o código do resultado";
            this.txtPesquisa.Enter += new System.EventHandler(this.txtPesquisa_Enter);
            this.txtPesquisa.Leave += new System.EventHandler(this.txtPesquisa_Leave);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(393, 40);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(182, 48);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEntrar);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.cmbIdade);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(404, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 370);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo jogo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faixa etária";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(144, 292);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(144, 56);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Jogar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNome.Location = new System.Drawing.Point(19, 43);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(394, 38);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Seu nome";
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.Location = new System.Drawing.Point(19, 120);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(394, 38);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "Seu e-mail (opcional)";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // cmbIdade
            // 
            this.cmbIdade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdade.FormattingEnabled = true;
            this.cmbIdade.Items.AddRange(new object[] {
            "12 a 15 anos",
            "16 a 17 anos"});
            this.cmbIdade.Location = new System.Drawing.Point(174, 204);
            this.cmbIdade.Name = "cmbIdade";
            this.cmbIdade.Size = new System.Drawing.Size(239, 39);
            this.cmbIdade.TabIndex = 2;
            // 
            // panelVoteBem
            // 
            this.panelVoteBem.BackColor = System.Drawing.Color.LightGreen;
            this.panelVoteBem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVoteBem.Controls.Add(this.label1);
            this.panelVoteBem.Location = new System.Drawing.Point(12, 12);
            this.panelVoteBem.Name = "panelVoteBem";
            this.panelVoteBem.Size = new System.Drawing.Size(372, 120);
            this.panelVoteBem.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz Vote Bem";
            // 
            // panelQuiz
            // 
            this.panelQuiz.Controls.Add(this.btnProximaPergunta);
            this.panelQuiz.Controls.Add(this.groupBox3);
            this.panelQuiz.Location = new System.Drawing.Point(12, 12);
            this.panelQuiz.Name = "panelQuiz";
            this.panelQuiz.Size = new System.Drawing.Size(1240, 657);
            this.panelQuiz.TabIndex = 7;
            this.panelQuiz.Visible = false;
            // 
            // btnProximaPergunta
            // 
            this.btnProximaPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximaPergunta.Location = new System.Drawing.Point(502, 576);
            this.btnProximaPergunta.Name = "btnProximaPergunta";
            this.btnProximaPergunta.Size = new System.Drawing.Size(236, 55);
            this.btnProximaPergunta.TabIndex = 3;
            this.btnProximaPergunta.Text = "Próxima pergunta";
            this.btnProximaPergunta.UseVisualStyleBackColor = true;
            this.btnProximaPergunta.Visible = false;
            this.btnProximaPergunta.Click += new System.EventHandler(this.btnProximaPergunta_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPerguntaAtual);
            this.groupBox3.Controls.Add(this.btnConfirmar);
            this.groupBox3.Controls.Add(this.picResposta2);
            this.groupBox3.Controls.Add(this.lblPergunta);
            this.groupBox3.Controls.Add(this.rbResposta2);
            this.groupBox3.Controls.Add(this.picResposta1);
            this.groupBox3.Controls.Add(this.rbResposta1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1234, 438);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quiz";
            // 
            // lblPerguntaAtual
            // 
            this.lblPerguntaAtual.AutoSize = true;
            this.lblPerguntaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerguntaAtual.Location = new System.Drawing.Point(559, 16);
            this.lblPerguntaAtual.Name = "lblPerguntaAtual";
            this.lblPerguntaAtual.Size = new System.Drawing.Size(117, 25);
            this.lblPerguntaAtual.TabIndex = 11;
            this.lblPerguntaAtual.Text = "Pergunta 1";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(807, 360);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(154, 52);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // picResposta2
            // 
            this.picResposta2.Location = new System.Drawing.Point(21, 244);
            this.picResposta2.Name = "picResposta2";
            this.picResposta2.Size = new System.Drawing.Size(50, 50);
            this.picResposta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResposta2.TabIndex = 13;
            this.picResposta2.TabStop = false;
            this.picResposta2.Visible = false;
            // 
            // lblPergunta
            // 
            this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(39, 68);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(1156, 81);
            this.lblPergunta.TabIndex = 8;
            this.lblPergunta.Text = "<Descrição da pergunta>";
            this.lblPergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbResposta2
            // 
            this.rbResposta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbResposta2.Location = new System.Drawing.Point(102, 244);
            this.rbResposta2.Name = "rbResposta2";
            this.rbResposta2.Size = new System.Drawing.Size(1093, 60);
            this.rbResposta2.TabIndex = 1;
            this.rbResposta2.TabStop = true;
            this.rbResposta2.Text = "<Resposta 2>";
            this.rbResposta2.UseVisualStyleBackColor = true;
            this.rbResposta2.CheckedChanged += new System.EventHandler(this.rbRespostaIncorreta_CheckedChanged);
            // 
            // picResposta1
            // 
            this.picResposta1.Location = new System.Drawing.Point(21, 171);
            this.picResposta1.Name = "picResposta1";
            this.picResposta1.Size = new System.Drawing.Size(50, 50);
            this.picResposta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResposta1.TabIndex = 12;
            this.picResposta1.TabStop = false;
            this.picResposta1.Visible = false;
            // 
            // rbResposta1
            // 
            this.rbResposta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbResposta1.Location = new System.Drawing.Point(102, 171);
            this.rbResposta1.Name = "rbResposta1";
            this.rbResposta1.Size = new System.Drawing.Size(1093, 60);
            this.rbResposta1.TabIndex = 0;
            this.rbResposta1.Text = "<Resposta 1>";
            this.rbResposta1.UseVisualStyleBackColor = true;
            this.rbResposta1.CheckedChanged += new System.EventHandler(this.rbRespostaCorreta_CheckedChanged);
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.lblEmailEnviado);
            this.panelResultado.Controls.Add(this.lblInstrucao);
            this.panelResultado.Controls.Add(this.lblCodigoPesquisa);
            this.panelResultado.Controls.Add(this.lblMensagem);
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Controls.Add(this.btnVoltar);
            this.panelResultado.Location = new System.Drawing.Point(12, 12);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(1240, 657);
            this.panelResultado.TabIndex = 8;
            this.panelResultado.Visible = false;
            // 
            // lblEmailEnviado
            // 
            this.lblEmailEnviado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailEnviado.Location = new System.Drawing.Point(43, 467);
            this.lblEmailEnviado.Name = "lblEmailEnviado";
            this.lblEmailEnviado.Size = new System.Drawing.Size(1156, 81);
            this.lblEmailEnviado.TabIndex = 13;
            this.lblEmailEnviado.Text = "Também foi enviado um e-mail com o resultado do Quiz";
            this.lblEmailEnviado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmailEnviado.Visible = false;
            // 
            // lblInstrucao
            // 
            this.lblInstrucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucao.ForeColor = System.Drawing.Color.DimGray;
            this.lblInstrucao.Location = new System.Drawing.Point(42, 357);
            this.lblInstrucao.Name = "lblInstrucao";
            this.lblInstrucao.Size = new System.Drawing.Size(1156, 81);
            this.lblInstrucao.TabIndex = 12;
            this.lblInstrucao.Text = "Use este código na página inicial para visualizar seu resultado novamente";
            this.lblInstrucao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigoPesquisa
            // 
            this.lblCodigoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPesquisa.Location = new System.Drawing.Point(42, 303);
            this.lblCodigoPesquisa.Name = "lblCodigoPesquisa";
            this.lblCodigoPesquisa.Size = new System.Drawing.Size(1156, 81);
            this.lblCodigoPesquisa.TabIndex = 11;
            this.lblCodigoPesquisa.Text = "O código de pesquisa do resultado do seu questionário é: ";
            this.lblCodigoPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(42, 219);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(1156, 81);
            this.lblMensagem.TabIndex = 10;
            this.lblMensagem.Text = "<Mensagem ao usuário>";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(42, 148);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(1156, 81);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Você acertou X de 6 perguntas";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(415, 576);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(410, 55);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar para página inicial";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmPaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelVoteBem);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.panelQuiz);
            this.Controls.Add(this.panelPaginaInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPaginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vote Bem - Página Inicial";
            this.panelPaginaInicial.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelVoteBem.ResumeLayout(false);
            this.panelVoteBem.PerformLayout();
            this.panelQuiz.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResposta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResposta1)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPaginaInicial;
        private System.Windows.Forms.Panel panelVoteBem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.ComboBox cmbIdade;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panelQuiz;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblPerguntaAtual;
        private System.Windows.Forms.RadioButton rbResposta2;
        private System.Windows.Forms.RadioButton rbResposta1;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Button btnProximaPergunta;
        private System.Windows.Forms.PictureBox picResposta2;
        private System.Windows.Forms.PictureBox picResposta1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblEmailEnviado;
        private System.Windows.Forms.Label lblInstrucao;
        private System.Windows.Forms.Label lblCodigoPesquisa;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblResultado;
    }
}

