namespace Cadastros.Domain.Entities
{
    public class Telefone
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public int FornecedorId { get; set; }
    }
}
