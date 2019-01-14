using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using ADO .NET.
using System.Data;
using System.Data.SqlClient;

namespace DATAACCESS
{
    public class AcessoDados
    {
        // Criar a conexão com o banco de dados.
        public SqlConnection CriarConexao()
        {
            return new SqlConnection(Properties.Settings.Default.con);
        }

        // Parâmetros que irão para o banco.
        SqlParameterCollection sqlParamameterCollection = new SqlCommand().Parameters;

        // Limpar os parâmetros.
        public void LimparParametros()
        {
            sqlParamameterCollection.Clear();
        }

        // Adicionar parâmetros
        public void AdicionarParametros(string nome, string valor)
        {
            sqlParamameterCollection.Add(new SqlParameter(nome, valor));
        }

        public object ExecutarPersistencia(CommandType cmdoType, string textoSql, bool read = true)
        {
            try
            {
                // Criar a conexão com o banco.
                SqlConnection sqlConnection = CriarConexao();

                // Abrir a conexão.
                sqlConnection.Open();

                // Criar o comando que vai até o bd.
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                // Adicionar os dados dentro do comando.
                sqlCommand.CommandType = cmdoType;
                sqlCommand.CommandText = textoSql;
                sqlCommand.CommandTimeout = 3600;

                // Varre os parâmetros e coloca nome e valor do parâmetro dentro da "caixa" de parâmetros.
                foreach (SqlParameter sqlParameter in sqlParamameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                // Se 'read' for true executa um select, se for false faz um insert/update/delete.
                if (read) return sqlCommand.ExecuteReader();
                else return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ExecutarConsulta(CommandType cmdoType, string textoSql)
        {
            try
            {
                // Criar a conexão.
                SqlConnection sqlConnection = CriarConexao();

                // Abrir a conexão.
                sqlConnection.Open();

                // Criar o comando que vai levar as informações até o BD.
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = cmdoType;
                sqlCommand.CommandText = textoSql;
                sqlCommand.CommandTimeout = 3600;

                foreach (SqlParameter sqlParameter in sqlParamameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                // Criar um adaptador de dados SQL.
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // Criar um DataTable para receber os dados que vem do banco.
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
