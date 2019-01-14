using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Imovel
    {
        public Cliente Cliente { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data_aquisicao { get; set; }        
    }
}
