using Cadastros.Domain.Entities;

namespace Cadastros.Domain.DTO
{
    public class TelefoneDTO
    {
        public int id { get; set; }
        public string numero { get; set; }
        public int fornecedorId { get; set; }
        public Telefone mapToEntity()
        {
            return new Telefone
            {
                Id = this.id,
                Numero = this.numero,
                FornecedorId = this.fornecedorId,
            };
        }
        public TelefoneDTO mapToDTO(Telefone telefone)
        {
            return new TelefoneDTO
            {
                id = telefone.Id,
                numero = telefone.Numero,
                fornecedorId = telefone.FornecedorId,
            };
        }

    }
}
