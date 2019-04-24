using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaFacil.Models
{
    [Table("ASSUNTO")]
    public class Assunto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cod_assunto { get; set; }

        [Display(Name = "Assunto")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(20, ErrorMessage = "Máximo de {1} caracteres.")]
        public string Nome_assunto { get; set; }
    }
}