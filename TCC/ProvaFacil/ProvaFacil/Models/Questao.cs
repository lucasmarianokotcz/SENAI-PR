using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaFacil.Models
{
    [Table("QUESTAO")]
    public class Questao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cod_questao { get; set; }

        [Display(Name = "Tipo da questão")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(20, ErrorMessage = "Máximo de {1} caracteres.")]
        [Required]
        public string Tipo_questao { get; set; }

        [Display(Name = "Descrição da questão")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(1500, ErrorMessage = "Máximo de {1} caracteres.")]
        [Required]
        public string Descricao_questao { get; set; }

        [Display(Name = "Valor da questão")]
        public decimal Valor_questao { get; set; }

        public ICollection<Opcao> Opcao { get; set; }
    }
}