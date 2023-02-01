using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBludata.Domain.Entities
{
    public class Empresa
    {
        public int Id { get; set; }
        public UF Uf { get; set; }
        public string NomeFantasia { get; set; }
        public string EmpesaCNPJ { get; set; }
    }
}
