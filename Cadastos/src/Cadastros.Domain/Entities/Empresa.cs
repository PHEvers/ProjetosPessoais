namespace Cadastros.Domain.Entities
{
    public class Empresa
    {
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public int UFId { get; set; }
        public virtual List<Fornecedor>? ListaFornecedor { get; set; }
    }
}
