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
    public class PedidoBusiness
    {
        AcessoDados acesso = new AcessoDados();

        #region Inserção de pedido no banco de dados
        public void InserirPedido(Pedido pedido)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@VALOR_PEDIDO", pedido.Valor_pedido.ToString().Replace(",", "."));
                acesso.AdicionarParametros("@PRECO_CACHORRO_QUENTE", pedido.Preco_cachorro_quente.ToString().Replace(",", "."));
                acesso.AdicionarParametros("@QTD_CACHORRO_QUENTE", pedido.Qtd_cachorro_quente.ToString());
                acesso.AdicionarParametros("@PRECO_HAMBURGER", pedido.Preco_hamburger.ToString().Replace(",", "."));
                acesso.AdicionarParametros("@QTD_HAMBURGER", pedido.Qtd_hamburger.ToString());
                acesso.AdicionarParametros("@PRECO_REFRI_1L", pedido.Preco_refri_1l.ToString().Replace(",", "."));
                acesso.AdicionarParametros("@QTD_REFRI_1L", pedido.Qtd_refri_1l.ToString());
                acesso.AdicionarParametros("@PRECO_REFRI_2L", pedido.Preco_refri_2l.ToString().Replace(",", "."));
                acesso.AdicionarParametros("@QTD_REFRI_2L", pedido.Qtd_refri_2l.ToString());

                string query = "INSERT INTO pedido (VALOR_PEDIDO, PRECO_CACHORRO_QUENTE, QTD_CACHORRO_QUENTE, " +
                                "PRECO_HAMBURGER, QTD_HAMBURGER, PRECO_REFRI_1L, QTD_REFRI_1L, PRECO_REFRI_2L, QTD_REFRI_2L) " +
                                "VALUES (@VALOR_PEDIDO, @PRECO_CACHORRO_QUENTE, @QTD_CACHORRO_QUENTE, @PRECO_HAMBURGER, @QTD_HAMBURGER, " +
                                "@PRECO_REFRI_1L, @QTD_REFRI_1L, @PRECO_REFRI_2L, @QTD_REFRI_2L)";

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
