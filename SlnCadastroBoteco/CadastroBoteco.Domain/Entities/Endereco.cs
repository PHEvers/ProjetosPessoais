using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroBoteco.Domain.Entities
{
    public class Endereco
    {
        public int CEP { get; set; }
        public int EnderecoID { get;set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int Numeracao { get; set; }

    }
}
