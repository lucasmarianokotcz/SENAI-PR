using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaFacil.Models
{
    [Table("OPCAO")]
    public class Opcao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cod_opcao { get; set; }

        [Display(Name = "Descrição da opção")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(150, ErrorMessage = "Máximo de {1} caracteres.")]
        public string Descricao_opcao { get; set; }

        [Display(Name = "Opção correta?")]
        public bool Opcao_correta { get; set; }

        public Questao Questao { get; set; }
        public int Cod_questao { get; set; }
    }
}