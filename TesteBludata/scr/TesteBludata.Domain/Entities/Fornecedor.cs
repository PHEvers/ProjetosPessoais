using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBludata.Domain.Entities
{
    public class Fornecedor
    {
        public Empresa Empresa { get; set; }
        public string Nome { get; set; }
        public string CPFCNPJ { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<string> Telefone { get; set; }
    }
}
