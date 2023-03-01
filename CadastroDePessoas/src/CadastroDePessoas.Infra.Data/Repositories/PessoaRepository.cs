using CadastroDePessoas.Domain.Entities;
using CadastroDePessoas.Domain.IRepositories;
using CadastroDePessoas.Infra.Data.Context;
using Cadastros.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CadastroDePessoas.Infra.Data.Repositories
{
    public class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
    {
        private readonly SQLServerContext _context;
        public PessoaRepository(SQLServerContext context) : base(context)
        {

        }
    }
}
