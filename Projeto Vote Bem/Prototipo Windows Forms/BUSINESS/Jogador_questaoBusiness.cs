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
    public class Jogador_questaoBusiness
    {
        AcessoDados acesso = new AcessoDados();

        #region Pegar o último ID do Jogador Cadastrado
        public DataTable PegarCod_jogador()
        {
            try
            {
                string query = "SELECT MAX(COD_JOGADOR) AS 'ULTIMO ID' FROM jogador";

                return acesso.ExecutarConsulta(CommandType.Text, query);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion

        #region Inserir Respostas do Jogador
        public void InserirRespostas(int cod_Jogador, int cod_Questao, string resposta_Jogador)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@COD_JOGADOR", cod_Jogador.ToString());
                acesso.AdicionarParametros("@COD_QUESTAO", cod_Questao.ToString());
                acesso.AdicionarParametros("@RESPOSTA_JOGADOR", resposta_Jogador);

                string query = "INSERT INTO jogador_questao (jogador_questao.COD_JOGADOR, jogador_questao.COD_QUESTAO, jogador_questao.RESPOSTA_JOGADOR) " +
                    "VALUES (@COD_JOGADOR, @COD_QUESTAO, @RESPOSTA_JOGADOR)";

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
