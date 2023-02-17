using Cadastros.Domain.Entities;
using Cadastros.Domain.IRepositories;
using Cadastros.Infra.Data.Context;

namespace Cadastros.Infra.Data.Repositories
{
    public class TelefoneRepository : BaseRepository<Telefone>, ITelefoneRepository
    {
        private readonly SQLServerContext _context;
        public TelefoneRepository(SQLServerContext context) : base(context)
        {

        }

    }
}
