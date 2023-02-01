using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TesteBludata.Domain.Entities;

namespace TesteBludata.Domain.DTO
{
    public class EmpresaDTO
    {
        public int id { get; set; }
        public UF uF { get; set; }

        [Required(ErrorMessage = "Por favor, digita um titulo.")]
        [MinLength(3, ErrorMessage = "Title should bigger than 3 charactere")]
        public string nomeFantasia { get; set; }
        [Required(ErrorMessage = "digite apenas os numeros do CNPJ")]
        [MinLength(14, ErrorMessage = "Title should bigger than 14 charactere")]
        public string empesaCNPJ { get; set; }
    }
}
