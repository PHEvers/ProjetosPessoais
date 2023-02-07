namespace Cadastros.Domain.Entities
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public int EmpresaId { get; set; }
        public string Nome { get; set; }
        public string CPF_CNPJ { get; set; }
        public virtual string RG { get; set; }
        //public DateTime DataCadastro { get; set; }
        //public virtual DateTime DataDeNascimento { get; set; }
        //public ICollection<Telefones> TelefonesList { get; set; }
    }
}
