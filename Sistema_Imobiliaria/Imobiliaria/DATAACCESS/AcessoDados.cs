using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using ADO .NET.
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace DATAACCESS
{
    public class AcessoDados
    {
        // Definir caminho da conexão com o banco de dados.
        public SqlConnection CriarConexao()
        {
            return new SqlConnection(Properties.Settings.Default.con);
        }

        // Coleção de parâmetros que poderão ir para o banco.
        SqlParameterCollection colecaoDeParametrosSql = new SqlCommand().Parameters;

        // Método para limpar os parâmetros da SqlParameterCollection criada.
        public void LimparParametros()
        {
            colecaoDeParametrosSql.Clear();
        }

        // Método para adicionar parâmetros a coleção de parâmetros criada.
        public void AdicionarParametros(string nome, string valor)
        {
            colecaoDeParametrosSql.Add(new SqlParameter(nome, valor));
        }

        // Método que faz a manipulação de comandos que serão enviados ao banco.
        public object ExecutarPersistencia(CommandType cmdoType, string textoSql, bool read = true)
        {
            try
            {
                // Cria a conexão com o banco.
                SqlConnection conexaoSql = CriarConexao();

                // Abre a conexão.
                conexaoSql.Open();

                // Criar o comando que vai até o banco.
                SqlCommand comandoSql = conexaoSql.CreateCommand();

                // Adicionar os dados dentro do comando.
                comandoSql.CommandType = cmdoType;
                comandoSql.CommandText = textoSql;
                comandoSql.CommandTimeout = 3600;

                // Varre os parâmetros e coloca nome e valor do parâmetro dentro da "caixa" de parâmetros.
                foreach (SqlParameter parametro in colecaoDeParametrosSql)
                {
                    comandoSql.Parameters.Add(new SqlParameter(parametro.ParameterName, parametro.Value));
                }

                // Se 'read' for true, executa um SELECT. Se for false, faz um insert/update/delete.
                if (read) return comandoSql.ExecuteReader();
                else return comandoSql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        // Método para buscar todos os valores de uma tabela do banco.
        public DataTable ExecutarConsulta(CommandType cmdoType, string textoSql)
        {
            try
            {
                // Criar a conexão.
                SqlConnection conexaoSql = CriarConexao();

                // Abre a conexão.
                conexaoSql.Open();

                // Criar o comando que vai levar as informações até o BD.
                SqlCommand comandoSql = conexaoSql.CreateCommand();
                comandoSql.CommandType = cmdoType;
                comandoSql.CommandText = textoSql;
                comandoSql.CommandTimeout = 3600;

                // Varre os parâmetros na coleção de parâmetros.
                foreach (SqlParameter parametro in colecaoDeParametrosSql)
                {
                    comandoSql.Parameters.Add(new SqlParameter(parametro.ParameterName, parametro.Value));
                }

                // Criar um adaptador de dados SQL.
                SqlDataAdapter adaptadorSql = new SqlDataAdapter(comandoSql);

                // Criar um DataTable para receber os dados que vem do banco.
                DataTable dataTable = new DataTable();
                adaptadorSql.Fill(dataTable);
                return dataTable;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}
