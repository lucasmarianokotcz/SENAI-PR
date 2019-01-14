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
    public class ClienteBusiness
    {
        // Cria um novo acesso a dados.
        AcessoDados acesso = new AcessoDados();

        #region Inserir
        public void Inserir(Cliente cliente)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@NOME", cliente.Nome);
                acesso.AdicionarParametros("@EMAIL", cliente.Email);
                acesso.AdicionarParametros("@ENDERECO", cliente.Endereco);
                acesso.AdicionarParametros("@COMPLEMENTO", cliente.Complemento);
                acesso.AdicionarParametros("@CIDADE", cliente.Cidade);
                acesso.AdicionarParametros("@ESTADO", cliente.Estado);
                acesso.AdicionarParametros("@TELEFONE", cliente.Telefone);
                acesso.AdicionarParametros("@DATA_NASC", cliente.Data_nasc.ToShortDateString());

                string query = "INSERT INTO cliente (NOME, EMAIL, ENDERECO, COMPLEMENTO, CIDADE, ESTADO, TELEFONE, DATA_NASC) " +
                    "VALUES (@NOME, @EMAIL, @ENDERECO, @COMPLEMENTO, @CIDADE, @ESTADO, @TELEFONE, @DATA_NASC)";

                // Executa o comando para enviar ao banco os valores. (tipo de comando Texto, enviando a 'query', false é para INSERT).
                acesso.ExecutarPersistencia(CommandType.Text, query, false);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion

        #region Alterar
        public void Alterar(Cliente cliente)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@ID_CLIENTE", cliente.Id_cliente.ToString());
                acesso.AdicionarParametros("@NOME", cliente.Nome);
                acesso.AdicionarParametros("@EMAIL", cliente.Email);
                acesso.AdicionarParametros("@ENDERECO", cliente.Endereco);
                acesso.AdicionarParametros("@COMPLEMENTO", cliente.Complemento);
                acesso.AdicionarParametros("@CIDADE", cliente.Cidade);
                acesso.AdicionarParametros("@ESTADO", cliente.Estado);
                acesso.AdicionarParametros("@TELEFONE", cliente.Telefone);
                acesso.AdicionarParametros("@DATA_NASC", cliente.Data_nasc.ToShortDateString());

                string query = "UPDATE cliente SET " +
                    "NOME = @NOME, EMAIL = @EMAIL, ENDERECO = @ENDERECO, COMPLEMENTO = @COMPLEMENTO, CIDADE = @CIDADE, ESTADO = @ESTADO, TELEFONE = @TELEFONE, DATA_NASC = @DATA_NASC " +
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
        public void Excluir(Cliente cliente, bool vezDoImovel)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@ID_CLIENTE", cliente.Id_cliente.ToString());

                string query;

                switch (vezDoImovel)
                {
                    case true:
                        query = "DELETE FROM imovel WHERE ID_CLIENTE = @ID_CLIENTE";
                        break;
                    default:
                        query = "DELETE FROM cliente WHERE ID_CLIENTE = @ID_CLIENTE";
                        break;
                }

                // Executa o comando para enviar ao banco os valores. (tipo de comando Texto, enviando a 'query', false é para INSERT/UPDATE/DELETE).
                acesso.ExecutarPersistencia(CommandType.Text, query, false);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion

        #region Carregar Dados
        public ClienteLista CarregarDadosCliente()
        {
            try
            {
                ClienteLista clientes = new ClienteLista();
                string query = "SELECT * FROM cliente";
                DataTable dataTableCliente = acesso.ExecutarConsulta(CommandType.Text, query);

                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();
                    cliente.Id_cliente = Convert.ToInt32(linha["ID_CLIENTE"]);
                    cliente.Nome = Convert.ToString(linha["NOME"]);
                    cliente.Email = Convert.ToString(linha["EMAIL"]);
                    cliente.Endereco = Convert.ToString(linha["ENDERECO"]);
                    cliente.Complemento = Convert.ToString(linha["COMPLEMENTO"]);
                    cliente.Cidade = Convert.ToString(linha["CIDADE"]);
                    cliente.Estado = Convert.ToString(linha["ESTADO"]);
                    cliente.Telefone = Convert.ToString(linha["TELEFONE"]);
                    cliente.Data_nasc = Convert.ToDateTime(linha["DATA_NASC"]);
                    clientes.Add(cliente);
                }

                return clientes;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion

        #region Buscar Cliente por ID
        public DataTable BuscarClientePorId(Cliente cliente, bool vezDoCliente)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@ID_CLIENTE", cliente.Id_cliente.ToString());

                string query;

                // Verifica qual DataGridView será preenchido. Se for 'true', será preenchido o DataGridView do Cliente. Se for false, dos Imóveis.
                switch (vezDoCliente)
                {
                    case true:
                        query = "SELECT * FROM cliente WHERE ID_CLIENTE = @ID_CLIENTE";
                        break;
                    default:
                        query = "SELECT * FROM imovel WHERE ID_CLIENTE = @ID_CLIENTE";
                        break;
                }

                // Faz a consulta e retorna com os dados do cliente pesquisado.
                return acesso.ExecutarConsulta(CommandType.Text, query);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion

        #region Buscar Cliente por Nome
        public DataTable BuscarClientePorNome(Cliente cliente, bool vezDoCliente)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@NOME", cliente.Nome);
                acesso.AdicionarParametros("@ID_CLIENTE", cliente.Id_cliente.ToString());

                string query;

                // Verifica qual DataGridView será preenchido. Se for 'true', será preenchido o DataGridView do Cliente. Se for false, dos Imóveis.
                switch (vezDoCliente)
                {
                    case true:
                        query = "SELECT * FROM cliente WHERE NOME LIKE @NOME + '%'";
                        break;
                    default:
                        query = "SELECT * FROM imovel WHERE ID_CLIENTE = @ID_CLIENTE";
                        break;
                }

                // Faz a consulta e retorna com os dados do cliente pesquisado.
                return acesso.ExecutarConsulta(CommandType.Text, query);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion
    }
}
