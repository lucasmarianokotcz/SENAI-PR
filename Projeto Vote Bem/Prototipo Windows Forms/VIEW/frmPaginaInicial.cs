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
    public partial class frmPaginaInicial : Form
    {
        // Variável para saber qual é a pergunta atual a ser respondida.
        private int perguntaAtual = 0;

        // DataTable que armazenará as questões buscadas no banco.
        private DataTable questoes;

        // Variável para saber se o jogador já confirmou ou não sua resposta.
        private bool confirmou = false;

        // Variável para contar pontuação do jogador.
        private int pontuacao = 0;

        // Variável para armazenar as respostas do jogador ao longo do Quiz.
        private string[] respostas = new string[6];

        public frmPaginaInicial()
        {
            InitializeComponent();
            ActiveControl = panelVoteBem;
        }

        #region Métodos
        // Método que vai buscar as questões no Business de acordo com a faixa etária do jogador.
        public void BuscarQuestoes(string faixaEtaria)
        {
            // Se o campo de e-mail estiver vazio, então limpe o textbox.
            if (txtEmail.ForeColor == Color.DarkGray)
            {
                txtEmail.Clear();
            }

            // Esconde o panel da Página Inicial e mostra o Panel do Quiz.
            panelPaginaInicial.Visible = false;
            Text = "Vote Bem - Quiz";
            panelQuiz.Visible = true;

            // Cria objeto da classe PerguntaBusiness passando a dificuldade das questões.
            QuestaoBusiness perguntaBusiness = new QuestaoBusiness();
            questoes = perguntaBusiness.BuscarQuestoesQuiz(faixaEtaria);

            // Chama o método 'QuestaoAtual' passando a pergunta atual a ser respondida no Quiz.
            QuestaoAtual(perguntaAtual);
        }

        // Método que carrega a questão atual no Quiz no Label da Pergunta e nos Radio Buttons das Respostas.
        public void QuestaoAtual(int perguntaAtual)
        {
            // Carrega a descrição da pergunta.
            lblPergunta.Text = Convert.ToString(questoes.Rows[perguntaAtual]["DESCRICAO"]);

            // Carrega as respostas da pergunta.
            // Sorteia um número aleatório entre 0 e 1. Se cair 0, a resposta certa estará no primeiro Radio Button, se cair 1, a resposta certa estará no segundo Radio Button.
            Random aleatorio = new Random();
            switch (aleatorio.Next(0, 2))
            {
                case 0:
                    rbResposta1.Text = Convert.ToString(questoes.Rows[perguntaAtual]["RESPOSTA_CORRETA"]);
                    rbResposta2.Text = Convert.ToString(questoes.Rows[perguntaAtual]["RESPOSTA_INCORRETA"]);
                    break;
                default:
                    rbResposta1.Text = Convert.ToString(questoes.Rows[perguntaAtual]["RESPOSTA_INCORRETA"]);
                    rbResposta2.Text = Convert.ToString(questoes.Rows[perguntaAtual]["RESPOSTA_CORRETA"]);
                    break;
            }
        }
        #endregion

        #region Controles/Ações referentes ao Panel da Página Inicial
        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.ForeColor == Color.DarkGray)
            {
                txtNome.Clear();
                txtNome.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.ForeColor == Color.DarkGray)
            {
                txtEmail.Clear();
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
            if (txtPesquisa.ForeColor == Color.DarkGray)
            {
                txtPesquisa.Clear();
                txtPesquisa.ForeColor = Color.Black;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                txtNome.ForeColor = Color.DarkGray;
                txtNome.Text = "Seu nome";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.ForeColor = Color.DarkGray;
                txtEmail.Text = "Seu e-mail (opcional)";
            }
        }

        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                txtPesquisa.ForeColor = Color.DarkGray;
                txtPesquisa.Text = "Digite o código do resultado";
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text) && txtNome.ForeColor == Color.Black)
            {
                // Switch para entrar no Quiz de acordo com a faixa etária.
                switch (cmbIdade.Text)
                {
                    case "12 a 15 anos":
                        BuscarQuestoes(cmbIdade.Text);
                        break;

                    case "16 a 17 anos":
                        BuscarQuestoes(cmbIdade.Text);
                        break;

                    default:
                        MessageBox.Show("Selecione uma faixa etária.", "Faixa etária", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbIdade.Focus();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo nome.", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria um jogadorBusiness que fará a busca do resultado do jogador.
                JogadorBusiness jogadorBusiness = new JogadorBusiness();

                // Cria um jogador e atribui o ID dele vindo do 'txtPesquisa'.
                Jogador jogador = new Jogador
                {
                    Cod_jogador = Convert.ToInt32(txtPesquisa.Text)
                };

                // Verifica se o foi encontrado um jogador no DataTable retornado da função 'BuscarDadosJogador' passando o 'jogador' como parâmetro.
                // Se a contagem de linhas deste DataTable for 1, significa que encontrou o jogador pesquisado.
                switch (jogadorBusiness.BuscarDadosJogador(jogador).Rows.Count)
                {
                    case 1:
                        {
                            // Cria um novo form enviando o jogador pesquisado para ser carregado nos DataGridView's.
                            frmResultado frmResultado = new frmResultado(jogadorBusiness.BuscarDadosJogador(jogador), jogadorBusiness.BuscarQuestoesJogador(jogador));
                            frmResultado.ShowDialog();
                            break;
                        }

                    default:
                        MessageBox.Show("Código não encontrado.", "Erro ao buscar resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Código não encontrado.", "Erro ao buscar resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Controles/Ações referentes ao Panel do Quiz
        private void rbRespostaCorreta_CheckedChanged(object sender, EventArgs e)
        {
            if (confirmou == false)
            {
                btnConfirmar.Visible = true;
                btnConfirmar.Enabled = true;
            }
        }

        private void rbRespostaIncorreta_CheckedChanged(object sender, EventArgs e)
        {
            if (confirmou == false)
            {
                btnConfirmar.Visible = true;
                btnConfirmar.Enabled = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            confirmou = true;

            // Indica a resposta correta para o usuário.
            // Se a primeira resposta estiver selecionada.
            if (rbResposta1.Checked)
            {
                // Resposta certa.
                if (rbResposta1.Text == Convert.ToString(questoes.Rows[perguntaAtual]["RESPOSTA_CORRETA"]))
                {
                    picResposta1.Image = Properties.Resources.Resposta_certa;
                    picResposta1.Visible = true;
                    rbResposta1.ForeColor = Color.Green;
                    pontuacao++;
                }
                // Resposta errada.
                else
                {
                    picResposta1.Image = Properties.Resources.Resposta_errada;
                    picResposta1.Visible = true;
                    rbResposta1.ForeColor = Color.Red;
                }

                // Armazena a resposta do jogador no vetor.
                respostas[perguntaAtual] = rbResposta1.Text;
            }
            // Se a segunda resposta estiver selecionada.
            else
            {
                // Resposta certa.
                if (rbResposta2.Text == Convert.ToString(questoes.Rows[perguntaAtual]["RESPOSTA_CORRETA"]))
                {
                    picResposta2.Image = Properties.Resources.Resposta_certa;
                    picResposta2.Visible = true;
                    rbResposta2.ForeColor = Color.Green;
                    pontuacao++;
                }
                // Resposta errada.
                else
                {
                    picResposta2.Image = Properties.Resources.Resposta_errada;
                    picResposta2.Visible = true;
                    rbResposta2.ForeColor = Color.Red;
                }

                // Armazena a resposta do jogador no vetor.
                respostas[perguntaAtual] = rbResposta2.Text;
            }

            // Arruma visualmente os botões para a próxima questão.
            btnConfirmar.Enabled = false;
            btnProximaPergunta.Visible = true;

            // Quando chegar na última pergunta, o botão "Próxima pergunta" ficará "Finalizar Quiz".
            if (perguntaAtual == 5)
            {
                btnProximaPergunta.Text = "Finalizar Quiz";
            }
        }

        private void btnProximaPergunta_Click(object sender, EventArgs e)
        {
            // Aumenta o valor de 'perguntaAtual' para que seja carregada a próxima pergunta a ser respondida.
            if (perguntaAtual + 1 < 6)
            {
                perguntaAtual++;

                btnProximaPergunta.Visible = false;
                rbResposta2.Enabled = true;
                rbResposta1.Enabled = true;
                rbResposta2.Checked = false;
                rbResposta1.Checked = false;
                btnConfirmar.Visible = false;

                // Indica no form qual é o número da questão atual.
                lblPerguntaAtual.Text = "Pergunta " + (perguntaAtual + 1);

                // Carrega a próxima pergunta do Quiz.
                QuestaoAtual(perguntaAtual);

                // Remove indicações visuais da pergunta anterior.
                picResposta1.Visible = false;
                picResposta2.Visible = false;
                rbResposta1.ForeColor = Color.Black;
                rbResposta2.ForeColor = Color.Black;

                confirmou = false;
            }
            else
            {
                // Criação do jogador com os atributos passados anteriormente.
                Jogador jogador = new Jogador
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    Idade = cmbIdade.Text,
                    Pontuacao = pontuacao
                };

                // Envia os dados do jogador para o banco.
                JogadorBusiness jogadorBusiness = new JogadorBusiness();
                jogadorBusiness.InserirDadosJogador(jogador);

                // Pega o ID do jogador pelo banco para ser passado para tabela das questões respondidas (jogador_questao).
                Jogador_questaoBusiness jogador_questaoBusiness = new Jogador_questaoBusiness();
                jogador.Cod_jogador = Convert.ToInt32(jogador_questaoBusiness.PegarCod_jogador().Rows[0]["ULTIMO ID"]);

                // Envia as respostas das questões para o BD, com código do jogador e código da questão.
                for (int i = 0; i < 6; i++)
                {
                    jogador_questaoBusiness.InserirRespostas(jogador.Cod_jogador, Convert.ToInt32(questoes.Rows[i]["COD_QUESTAO"]), respostas[i]);
                }

                // Esconde o panel do Quiz e mostra o Panel do Resultado.
                panelQuiz.Visible = false;
                Text = "Vote Bem - Resultado";
                panelResultado.Visible = true;

                // Exibe o resultado para o jogador.
                lblResultado.Text = "Você acertou " + pontuacao + " de 6 perguntas";

                // Define a mensagem ao jogador de acordo com sua pontuação.
                if (pontuacao > 3)
                {
                    lblMensagem.ForeColor = Color.Green;
                    lblMensagem.Text = "Parabéns. Você tem bons conhecimentos sobre política!";
                }
                else
                {
                    lblMensagem.ForeColor = Color.Red;
                    lblMensagem.Text = "Você não se saiu muito bem. Busque melhorar seus conhecimentos sobre política!";
                }

                // Exibe o código do resultado para o jogador.
                lblCodigoPesquisa.Text += jogador.Cod_jogador.ToString();
            }
        }
        #endregion

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Esconde o panel do Resultado e mostra o Panel da Página Inicial.
            panelResultado.Visible = false;
            Text = "Vote Bem - Página Inicial";
            panelPaginaInicial.Visible = true;

            // Reseta o software para novo Quiz.
            perguntaAtual = 0;
            pontuacao = 0;
            confirmou = false;

            txtNome.ForeColor = Color.DarkGray;
            txtEmail.ForeColor = Color.DarkGray;
            txtNome.Text = "Seu nome";
            txtEmail.Text = "Seu e-mail (opcional)";
            cmbIdade.Text = null;

            txtPesquisa.ForeColor = Color.DarkGray;
            txtPesquisa.Text = "Digite o código do resultado";

            rbResposta1.Checked = false;
            rbResposta2.Checked = false;
            rbResposta1.ForeColor = Color.Black;
            rbResposta2.ForeColor = Color.Black;

            picResposta1.Visible = false;
            picResposta2.Visible = false;

            btnConfirmar.Visible = false;
            btnProximaPergunta.Visible = false;

            lblPerguntaAtual.Text = "Pergunta " + (perguntaAtual + 1);
            lblCodigoPesquisa.Text = "O código de pesquisa do resultado do seu questionário é: ";
        }
    }
}
