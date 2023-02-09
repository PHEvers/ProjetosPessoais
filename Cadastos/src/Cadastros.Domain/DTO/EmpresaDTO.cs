using Cadastros.Domain.DTO;
using Cadastros.Domain.Entities;

namespace Cadastros.Domain.DTO
{
    public class EmpresaDTO
    {
        public int id { get; set; }
        public string nomeFantasia { get; set; }
        public string cNPJ { get; set; }
        public int ufId { get; set; }
        public List<FornecedorDTO>? listaFornecedor { get; set; }
        public Empresa mapToEntity()
        {
            return new Empresa
            {
                Id = this.id,
                NomeFantasia = this.nomeFantasia,
                CNPJ = this.cNPJ,
                UFId = this.ufId,
            };
        }
        public EmpresaDTO mapToDTO(Empresa empresa)
        {
            return new EmpresaDTO
            {
                id = empresa.Id,
                nomeFantasia = empresa.NomeFantasia,
                cNPJ = empresa.CNPJ,
                ufId = empresa.UFId,
            };
        }
    }
}
