using CadastroDePessoas.Domain.Entities;

namespace CadastroDePessoas.Domain.DTO
{
    public class PessoaDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string cidade { get; set; }
        public DateTime dataNascimento { get; set; }

        public Pessoa mapToEntity()
        {
            return new Pessoa
            {
                Id = id,
                Nome = this.nome,
                CPF = this.cpf,
                Cidade = this.cidade,
                DataNascimento = dataNascimento
            };
        }
        public PessoaDTO mapToDTO(Pessoa pessoa)
        {
            return new PessoaDTO
            {
                id = pessoa.Id,
                nome = pessoa.Nome,
                cpf = pessoa.CPF,
                cidade = pessoa.Cidade,
                dataNascimento = pessoa.DataNascimento
            };
        }
    }
}
