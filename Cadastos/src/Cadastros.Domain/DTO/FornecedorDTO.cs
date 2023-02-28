using Cadastros.Domain.Entities;

namespace Cadastros.Domain.DTO
{
    public class FornecedorDTO
    {
        public int id { get; set; }
        public int empresaId { get; set; }
        public string nome { get; set; }
        public bool pf { get; set; }
        public string cpf_cnpj { get; set; }
        public DateTime dataCadastro { get; set; }
        public virtual string? rg { get; set; }
        public virtual DateTime? dataDeNascimento { get; set; }
        public IEnumerable<TelefoneDTO>? telefoneList { get; set; }
        public Fornecedor mapToEntity()
        {
            return new Fornecedor
            {
                Id = this.id,
                EmpresaId = this.empresaId,
                PF = this.pf,
                Nome = this.nome,
                CPF_CNPJ = this.cpf_cnpj,
                RG = this.rg,
                DataCadastro = this.dataCadastro,
                DataDeNascimento = this.dataDeNascimento,
            };
        }
        public FornecedorDTO mapToDTO(Fornecedor fornecedor)
        {
            return new FornecedorDTO
            {
                id = fornecedor.Id,
                empresaId = fornecedor.EmpresaId,
                nome = fornecedor.Nome,
                pf = fornecedor.PF,
                cpf_cnpj = fornecedor.CPF_CNPJ,
                rg = fornecedor.RG,
                dataCadastro = fornecedor.DataCadastro,
                dataDeNascimento = fornecedor.DataDeNascimento
            };
        }
    }
}
