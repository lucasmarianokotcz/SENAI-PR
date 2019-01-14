using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DATAACCESS;
using MODEL;

namespace BUSINESS
{
    public class JogadorBusiness
    {
        AcessoDados acesso = new AcessoDados();

        #region Buscar dados do jogador
        public DataTable BuscarDadosJogador(Jogador jogador)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@COD_JOGADOR", jogador.Cod_jogador.ToString());

                // Query que será passada ao banco.
                string query = "SELECT jogador.COD_JOGADOR AS 'CÓDIGO DO JOGADOR', jogador.NOME, jogador.IDADE AS 'FAIXA ETÁRIA', jogador.PONTUACAO AS 'PONTUAÇÃO' FROM jogador WHERE" +
                    " jogador.COD_JOGADOR = @COD_JOGADOR";

                // Retorna o datatable com os dados do jogador.
                return acesso.ExecutarConsulta(CommandType.Text, query);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        #endregion

        #region Buscar questões do jogador
        public DataTable BuscarQuestoesJogador(Jogador jogador)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@COD_JOGADOR", jogador.Cod_jogador.ToString());

                // Query para BD.
                string query = "SELECT questao.DESCRICAO AS 'DESCRIÇÃO', questao.RESPOSTA_CORRETA AS 'RESPOSTA CORRETA', jogador_questao.RESPOSTA_JOGADOR AS 'SUA RESPOSTA' FROM" +
                    " jogador, questao, jogador_questao WHERE jogador.COD_JOGADOR = @COD_JOGADOR AND jogador_questao.COD_JOGADOR = @COD_JOGADOR AND jogador_questao.COD_QUESTAO = questao.COD_QUESTAO";

                // Retorna o datatable com os dados das questões do jogador.
                return acesso.ExecutarConsulta(CommandType.Text, query);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        #endregion

        #region Inserir dados do jogador
        public void InserirDadosJogador(Jogador jogador)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@NOME", jogador.Nome);
                acesso.AdicionarParametros("@EMAIL", jogador.Email);
                acesso.AdicionarParametros("@IDADE", jogador.Idade);
                acesso.AdicionarParametros("@PONTUACAO", jogador.Pontuacao.ToString());

                string query = "INSERT INTO jogador (jogador.NOME, jogador.EMAIL, jogador.IDADE, jogador.PONTUACAO) " +
                    "VALUES (@NOME, @EMAIL, @IDADE, @PONTUACAO)";

                acesso.ExecutarPersistencia(CommandType.Text, query, false);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        #endregion
    }
}
