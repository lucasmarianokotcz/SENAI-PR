using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DATAACCESS;
using MODEL;
using System.Data.SqlClient;

namespace BUSINESS
{
    public class AdminBusiness
    {
        // Cria um novo acesso a dados.
        AcessoDados acesso = new AcessoDados();

        public DataTable BuscarUsuario(Admin admin)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@LOGIN", admin.Login);
                acesso.AdicionarParametros("@SENHA", admin.Senha);

                string query = "SELECT LOGIN, SENHA FROM admin WHERE LOGIN = @LOGIN AND SENHA = @SENHA COLLATE SQL_Latin1_General_CP1_CS_AS";

                // Retorna um DataTable que faz a consulta caso o usuário e senha estejam no banco. (se retornar vazio, usuário ou senha inválidos).
                return acesso.ExecutarConsulta(CommandType.Text, query);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable BuscarLogin(Admin admin)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@LOGIN", admin.Login);

                string query = "SELECT LOGIN FROM admin WHERE LOGIN = @LOGIN";

                // Retorna um DataTable que faz a consulta caso o usuário esteja no banco. (se retornar vazio, usuário já existe).
                return acesso.ExecutarConsulta(CommandType.Text, query);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void CadastrarUsuario(Admin admin)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@LOGIN", admin.Login);
                acesso.AdicionarParametros("@SENHA", admin.Senha);

                string query = "INSERT INTO admin (LOGIN, SENHA) VALUES (@LOGIN, @SENHA)";

                // Executa o comando para enviar ao banco os valores. (tipo de comando Texto, enviando a 'query', false é para INSERT).
                acesso.ExecutarPersistencia(CommandType.Text, query, false);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
