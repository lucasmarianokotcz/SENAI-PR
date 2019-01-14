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
    public class QuestaoBusiness
    {
        AcessoDados acesso = new AcessoDados();

        #region Buscar questões para o Quiz
        public DataTable BuscarQuestoesQuiz(string dificuldade)
        {
            try
            {
                // Verifica a faixa etária e faz o SELECT do nível das questões de acordo.
                string query = dificuldade == "16 a 17 anos"
                    ? "SELECT TOP 6 * FROM questao WHERE questao.COD_QUESTAO <= 9 ORDER BY NEWID()"
                    : "SELECT TOP 6 * FROM questao WHERE questao.COD_QUESTAO >= 10 ORDER BY NEWID()";

                // DataTable que tem as questões buscadas.
                return acesso.ExecutarConsulta(CommandType.Text, query);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        #endregion
    }
}
