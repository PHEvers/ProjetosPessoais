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
        public int id { get; set; }
        public Empresa empresa { get; set; }
        public string nome { get; set; }
        public string cPFCNPJ { get; set; }
        public DateTime dataCadastro { get; set; }
        virtual public int rG { get; set; }
        virtual public DateTime dataNascimento { get; set; }
        //public List<string> telefone { get; set; }
        public Fornecedor mapToEntity()
        {
            return new Fornecedor
            {
                Id = this.id,
                Empresa = this.empresa,
                Nome = this.nome,
                CPFCNPJ = this.cPFCNPJ,
                DataCadastro = this.dataCadastro,
                RG = this.rG,
                DataNascimento = this.dataNascimento
            };
        }
        public FornecedorDTO mapToDTO(Fornecedor fornecedor)
        {
            return new FornecedorDTO
            {
                id = fornecedor.Id,
                empresa = fornecedor.Empresa,
                nome = fornecedor.Nome,
                cPFCNPJ = fornecedor.CPFCNPJ,
                dataCadastro = fornecedor.DataCadastro,
                rG = fornecedor.RG,
                dataNascimento = fornecedor.DataNascimento
            };
        }
    }
}
