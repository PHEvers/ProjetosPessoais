using Cadastros.Domain.Entities;

namespace Cadastros.Domain.DTO
{
    public class FornecedorDTO
    {

        public int id { get; set; }
        public int empresaId { get; set; }
        public string nome { get; set; }
        public string cpf_cnpj { get; set; }
        public string rg { get; set; }
        //public DateTime dataCadastro { get; set; }
        //public DateTime dataDeNascimento { get; set; }
        public List<string>? telefoneList { get; set; }
        public Fornecedor mapToEntity()
        {
            return new Fornecedor
            {
                Id = this.id,
                EmpresaId = this.empresaId,
                Nome = this.nome,
                CPF_CNPJ = this.cpf_cnpj,
                RG = this.rg,
                TelefonesList= this.telefoneList,
            };
        }
        public FornecedorDTO mapToDTO(Fornecedor fornecedor)
        {
            return new FornecedorDTO
            {
                id = fornecedor.Id,
                empresaId = fornecedor.EmpresaId,
                nome = fornecedor.Nome,
                cpf_cnpj = fornecedor.CPF_CNPJ,
                rg = fornecedor.RG,
                telefoneList = fornecedor.TelefonesList
            };
        }
    }
}
