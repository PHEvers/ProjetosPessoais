namespace CadastroDePessoas.Domain.Entities
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Cidade { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
