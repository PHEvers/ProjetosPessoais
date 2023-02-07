using Cadastros.Domain.Entities;

namespace Cadastros.Domain.DTO
{
    public class TelefonesDTO
    {
        public int id { get; set; }
        public string numero { get; set; }
        public string fornecedorId { get; set; }
        public Telefones mapToEntity()
        {
            return new Telefones
            {
                Id = id,
                Numero = numero,
                FornecedorId = fornecedorId,
            };
        }
        public TelefonesDTO mapToDTO(Telefones telefones)
        {
            return new TelefonesDTO
            {
                id = telefones.Id,
                numero = telefones.Numero,
                fornecedorId = telefones.FornecedorId
            };
        }
    }
}
