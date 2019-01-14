using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Pedido
    {
        public decimal Valor_pedido { get; set; }

        public decimal Preco_cachorro_quente { get; set; }
        public int Qtd_cachorro_quente { get; set; }

        public decimal Preco_hamburger { get; set; }
        public int Qtd_hamburger { get; set; }

        public decimal Preco_refri_1l { get; set; }
        public int Qtd_refri_1l { get; set; }

        public decimal Preco_refri_2l { get; set; }
        public int Qtd_refri_2l { get; set; }
    }
}
