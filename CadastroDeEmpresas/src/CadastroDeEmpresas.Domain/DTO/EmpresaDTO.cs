using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using CadastroDeEmpresas.Domain.Entities;

namespace CadastroDeEmpresas.Domain.DTO
{
    public class EmpresaDTO
    {
        public int id { get; set; }
        public UF uF { get; set; }

        [Required(ErrorMessage = "Por favor, digita um titulo.")]
        [MinLength(3, ErrorMessage = "Title should bigger than 3 charactere")]
        public string nomeFantasia { get; set; }
        [Required(ErrorMessage = "digite apenas os numeros do CNPJ")]
        [MinLength(14, ErrorMessage = "Title should be than 15 charactere")]
        [MaxLength(16, ErrorMessage = "Title should be than 15 charactere")]
        public string empesaCNPJ { get; set; }
        public Empresa mapToEntity()
        {

            return new Empresa()
            {
                Id = id,
                Uf = uF,
                EmpesaCNPJ = empesaCNPJ
            };
        }
        public EmpresaDTO mapToDTO(Empresa empresa)
        {
            return new EmpresaDTO()
            {
                id = empresa.Id,
                uF = empresa.Uf,
                empesaCNPJ = empresa.EmpesaCNPJ
            };
        }
    }
    
}
