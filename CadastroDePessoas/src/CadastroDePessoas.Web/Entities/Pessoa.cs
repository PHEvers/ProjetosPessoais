using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroDePessoas.Web.Entities
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("CPF")]
        public string CPF { get; set; }
        [Column("Cidade")]
        public string Cidade { get; set; }
        [Column("DataNascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
