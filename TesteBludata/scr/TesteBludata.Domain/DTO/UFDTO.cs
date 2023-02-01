using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBludata.Domain.Entities;

namespace TesteBludata.Domain.DTO
{
    public class UFDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public List<Empresa> listaEmpresa { get; set; }
    }
}
