using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeEmpresas.Domain.Entities;

namespace CadastroDeEmpresas.Domain.DTO
{
    public class UFDTO
    {
        [DisplayName("Id")]
        public int id { get; set; }
        public string nome { get; set; }
        public virtual ICollection<Empresa>? listaEmpresa { get; set; }
        public UFDTO mapToDTO(UF uf)
        {
            return new UFDTO
            {
                id = uf.Id,
                nome = uf.Nome,
            };
        } 
        public UF mapToEntity()
        {
            return new UF
            {
                Id = this.id,
                Nome = this.nome,
            };
        }
    }
}
