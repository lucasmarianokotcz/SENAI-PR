using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProvaFacil.Models
{
    [Table("CABECALHO")]
    public class Cabecalho
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cod_prova { get; set; }

        [Display(Name = "Data da prova")]
        [DataType(DataType.Date)]
        public DateTime Data_prova { get; set; }

        [Display(Name = "Valor da prova")]
        [Required]
        public decimal Valor_prova { get; set; }
    }
}