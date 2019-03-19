using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Avaliacao1LucasMariano.Models
{
    public class Funcionario
    {
        public int IdFunc { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Setor { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "Salário (R$)")]
        public decimal Salario { get; set; }
        [Display(Name = "Data de admissão")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DataAdmissao { get; set; }
        [Range(0, 10)]
        public int Filhos { get; set; }

        public List<Funcionario> ListaFuncionarios()
        {
            var funcionarios = new List<Funcionario>
            {
                new Funcionario {IdFunc = 1, Nome = "Lucas Mariano", Setor = "TI", Salario = 3800.00m, DataAdmissao = new DateTime(2014, 04, 12), Filhos = 0},
                new Funcionario {IdFunc = 2, Nome = "Giovanna Tedesco", Setor = "Contábil", Salario = 4200.00m, DataAdmissao = new DateTime(2015, 11, 04), Filhos = 0},
                new Funcionario {IdFunc = 3, Nome = "Alex Mariano", Setor = "TI", Salario = 3800.00m, DataAdmissao = new DateTime(2016, 08, 10), Filhos = 0},
                new Funcionario {IdFunc = 4, Nome = "José Silva", Setor = "Diretor", Salario = 14800.00m, DataAdmissao = new DateTime(2005, 01, 31), Filhos = 3},
                new Funcionario {IdFunc = 5, Nome = "Ana Maria", Setor = "Recursos Humanos", Salario = 3100.00m, DataAdmissao = new DateTime(2017, 04, 19), Filhos = 0},
                new Funcionario {IdFunc = 6, Nome = "Renata Freitas", Setor = "Recursos Humanos", Salario = 3100.00m, DataAdmissao = new DateTime(2014, 02, 04), Filhos = 1},
                new Funcionario {IdFunc = 7, Nome = "Felipe Camargo", Setor = "TI", Salario = 3800.00m, DataAdmissao = new DateTime(2011, 09, 30), Filhos = 2},
                new Funcionario {IdFunc = 8, Nome = "Maria Souza", Setor = "Contábil", Salario = 4200.00m, DataAdmissao = new DateTime(2014, 04, 12), Filhos = 2},
                new Funcionario {IdFunc = 9, Nome = "Luis Carlos", Setor = "TI", Salario = 3800m, DataAdmissao = new DateTime(2014, 04, 12), Filhos = 0},
                new Funcionario {IdFunc = 10, Nome = "Sara Helena", Setor = "Contábil", Salario = 4200m, DataAdmissao = new DateTime(2013, 02, 11), Filhos = 1},
            };
            return funcionarios;
        }
    }
}