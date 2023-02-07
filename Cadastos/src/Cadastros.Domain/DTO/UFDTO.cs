using Cadastros.Domain.Entities;

namespace Cadastros.Domain.DTO
{
    public class UFDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        //public virtual ICollection<Empresa> empresaList { get; set; }
        public UF mapToEntity()
        {
            return new UF
            {
                Id = this.id,
                Nome = this.nome
            };
        }
        public UFDTO mapToDTO(UF uf)
        {
            return new UFDTO
            {
                id = uf.Id,
                nome = uf.Nome
            };
        }
    }
}
