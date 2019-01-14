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

namespace VIEW
{
    public partial class frmResultado : Form
    {
        // Estiliza o DataGridView colocando cor verde para respostas corretas e cor vermelha para respostas incorretas.
        private void Estilo()
        {
            for (int i = 0; i < dgvResultadoQuestoes.Rows.Count; i++)
            {
                if (dgvResultadoQuestoes[1, i].Value.ToString() == dgvResultadoQuestoes[2, i].Value.ToString())
                {
                    dgvResultadoQuestoes[1, i].Style.ForeColor = Color.Green;
                    dgvResultadoQuestoes[2, i].Style.ForeColor = Color.Green;
                }
                else
                {
                    dgvResultadoQuestoes[1, i].Style.ForeColor = Color.Red;
                    dgvResultadoQuestoes[2, i].Style.ForeColor = Color.Red;
                }
            }
        }

        public frmResultado(DataTable jogador, DataTable questoes)
        {
            InitializeComponent();
            dgvResultadoJogador.DataSource = jogador;
            dgvResultadoQuestoes.DataSource = questoes;
        }

        public frmResultado()
        {

        }

        private void frmResultado_Load(object sender, EventArgs e)
        {
            dgvResultadoJogador.ClearSelection();
            dgvResultadoQuestoes.ClearSelection();

            // Estiliza o DGV.
            Estilo();
        }        
    }
}
