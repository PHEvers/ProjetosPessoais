using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeEmpresas.Domain.Entities;

namespace CadastroDeEmpresas.Domain.DTO
{
    public class FornecedorDTO
    {
        public Empresa empresa { get; set; }
        public string nome { get; set; }
        public string cPFCNPJ { get; set; }
        public DateTime dataCadastro { get; set; }
        virtual public int rG { get; set; }
        virtual public DateTime dataNascimento { get; set; }
        public List<string> telefone { get; set; }
    }
}
