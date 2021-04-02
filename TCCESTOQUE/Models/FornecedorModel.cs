using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCCESTOQUE.Models
{
    public class FornecedorModel : PessoaModel
    {
       
        [MaxLength(30, ErrorMessage = "O campo nome fantasia deve possuir apenas 30 caracteres!")]
        public string Nome_Fantasia { get; set; }
        [MaxLength(14, ErrorMessage = "O campo CPF deve possuir apenas 30 caracteres!")]
        public string CPF { get; set; }

    }
}
