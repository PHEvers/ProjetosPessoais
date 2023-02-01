using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBludata.Domain.Entities
{
    public class UF
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Empresa>? ListaEmpresa { get; set; }
    }
}
