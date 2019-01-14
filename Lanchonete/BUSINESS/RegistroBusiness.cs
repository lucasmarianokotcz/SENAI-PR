using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATAACCESS;
using MODEL;
using System.Data;

namespace BUSINESS
{
    public class RegistroBusiness
    {
        AcessoDados acesso = new AcessoDados();

        #region Verificar se chave existe no banco
        public DataTable VerifChave(Registro registro)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@COD_REGISTRO", registro.Cod_registro);

                // Busca no BD se a licença já foi utilizada através do código de registro inserido pelo usuário.
                string query = "SELECT JA_UTILIZADA FROM registro WHERE COD_REGISTRO = @COD_REGISTRO";

                return acesso.ExecutarConsulta(CommandType.Text, query);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion

        #region Atualizar registro no banco quando o usuário inserir licença do software
        public void AtualizarRegistro(Registro registro)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@COD_REGISTRO", registro.Cod_registro);

                // Atualiza o registro da chave de licença para marcá-la como já utilizada.
                string query = "UPDATE registro SET JA_UTILIZADA = 'TRUE' WHERE COD_REGISTRO = @COD_REGISTRO";

                acesso.ExecutarPersistencia(CommandType.Text, query, false);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion
    }
}
