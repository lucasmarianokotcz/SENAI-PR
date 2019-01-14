namespace VIEW
{
    partial class frmResultado
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
            this.panelVoteBem = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvResultadoJogador = new System.Windows.Forms.DataGridView();
            this.dgvResultadoQuestoes = new System.Windows.Forms.DataGridView();
            this.panelVoteBem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoQuestoes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVoteBem
            // 
            this.panelVoteBem.BackColor = System.Drawing.Color.LightGreen;
            this.panelVoteBem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVoteBem.Controls.Add(this.label1);
            this.panelVoteBem.Location = new System.Drawing.Point(12, 12);
            this.panelVoteBem.Name = "panelVoteBem";
            this.panelVoteBem.Size = new System.Drawing.Size(372, 120);
            this.panelVoteBem.TabIndex = 7;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(694, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jogador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(485, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Questões";
            // 
            // dgvResultadoJogador
            // 
            this.dgvResultadoJogador.AllowUserToAddRows = false;
            this.dgvResultadoJogador.AllowUserToDeleteRows = false;
            this.dgvResultadoJogador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultadoJogador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoJogador.Location = new System.Drawing.Point(390, 67);
            this.dgvResultadoJogador.Name = "dgvResultadoJogador";
            this.dgvResultadoJogador.ReadOnly = true;
            this.dgvResultadoJogador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultadoJogador.Size = new System.Drawing.Size(734, 160);
            this.dgvResultadoJogador.TabIndex = 9;
            // 
            // dgvResultadoQuestoes
            // 
            this.dgvResultadoQuestoes.AllowUserToAddRows = false;
            this.dgvResultadoQuestoes.AllowUserToDeleteRows = false;
            this.dgvResultadoQuestoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultadoQuestoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoQuestoes.Location = new System.Drawing.Point(12, 327);
            this.dgvResultadoQuestoes.Name = "dgvResultadoQuestoes";
            this.dgvResultadoQuestoes.ReadOnly = true;
            this.dgvResultadoQuestoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultadoQuestoes.Size = new System.Drawing.Size(1112, 270);
            this.dgvResultadoQuestoes.TabIndex = 10;
            // 
            // frmResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 609);
            this.Controls.Add(this.dgvResultadoQuestoes);
            this.Controls.Add(this.dgvResultadoJogador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelVoteBem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResultado";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vote Bem - Resultado";
            this.Load += new System.EventHandler(this.frmResultado_Load);
            this.panelVoteBem.ResumeLayout(false);
            this.panelVoteBem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoQuestoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVoteBem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvResultadoJogador;
        private System.Windows.Forms.DataGridView dgvResultadoQuestoes;
    }
}