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
    public class ImovelBusiness
    {
        // Cria um novo acesso a dados.
        AcessoDados acesso = new AcessoDados();

        #region Inserir
        public void Inserir(Imovel imovel)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@ID_CLIENTE", imovel.Cliente.Id_cliente.ToString());
                acesso.AdicionarParametros("@ENDERECO", imovel.Endereco);
                acesso.AdicionarParametros("@CIDADE", imovel.Cidade);
                acesso.AdicionarParametros("@ESTADO", imovel.Estado);
                acesso.AdicionarParametros("@TIPO", imovel.Tipo);
                acesso.AdicionarParametros("@VALOR", imovel.Valor.ToString().Replace(",","."));
                acesso.AdicionarParametros("@DATA_AQUISICAO", imovel.Data_aquisicao.ToShortDateString());
                               
                string query = "INSERT INTO imovel (ID_CLIENTE, ENDERECO, CIDADE, ESTADO, TIPO, VALOR, DATA_AQUISICAO) " +
                    "VALUES (@ID_CLIENTE, @ENDERECO, @CIDADE, @ESTADO, @TIPO, @VALOR, @DATA_AQUISICAO)";

                // Executa o comando para enviar ao banco os valores. (tipo de comando Texto, enviando a 'query', false é para INSERT/UPDATE/DELETE).
                acesso.ExecutarPersistencia(CommandType.Text, query, false);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion

        #region Alterar
        public void Alterar(Imovel imovel)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@ID_CLIENTE", imovel.Cliente.Id_cliente.ToString());
                acesso.AdicionarParametros("@ENDERECO", imovel.Endereco);
                acesso.AdicionarParametros("@CIDADE", imovel.Cidade);
                acesso.AdicionarParametros("@ESTADO", imovel.Estado);
                acesso.AdicionarParametros("@TIPO", imovel.Tipo);
                acesso.AdicionarParametros("@VALOR", imovel.Valor.ToString().Replace(",", "."));
                acesso.AdicionarParametros("@DATA_AQUISICAO", imovel.Data_aquisicao.ToShortDateString());

                string query = "UPDATE imovel SET " +
                    "ENDERECO = @ENDERECO, CIDADE = @CIDADE, ESTADO = @ESTADO, TIPO = @TIPO, VALOR = @VALOR, DATA_AQUISICAO = @DATA_AQUISICAO " +
                    "WHERE ID_CLIENTE = @ID_CLIENTE";

                // Executa o comando para enviar ao banco os valores. (tipo de comando Texto, enviando a 'query', false é para INSERT/UPDATE/DELETE).
                acesso.ExecutarPersistencia(CommandType.Text, query, false);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion

        #region Excluir
        public void Excluir(Imovel imovel)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@ID_CLIENTE", imovel.Cliente.Id_cliente.ToString());

                string query = "DELETE FROM imovel WHERE ID_CLIENTE = @ID_CLIENTE";

                // Executa o comando para enviar ao banco os valores. (tipo de comando Texto, enviando a 'query', false é para INSERT/UPDATE/DELETE).
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
