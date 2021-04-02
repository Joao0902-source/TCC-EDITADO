using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCCESTOQUE.Models
{
    public class ProdutoModel 
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30, ErrorMessage = "O campo nome deve possuir apenas 30 caracteres!")]
        public string Nome { get; set; }

        [MaxLength(30, ErrorMessage = "O campo descrição deve possuir apenas 30 caracteres!")]
        public string Descricao { get; set; }

        [MaxLength(5, ErrorMessage = "O campo de custo deve possuir apenas 30 caracteres!")]
        public int Custo { get; set; }

        [MaxLength(5, ErrorMessage = "O campo de valor unitário deve possuir apenas 30 caracteres!")]
        public int Val_Unit { get; set; }
        [MaxLength(5, ErrorMessage = "O campo de quantidade deve possuir apenas 30 caracteres!")]
        public int Quantidade { get; set; }

        public DateTime Data_Entrada { get; set; }






    }

}
