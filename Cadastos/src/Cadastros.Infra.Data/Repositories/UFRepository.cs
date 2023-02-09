using Cadastros.Domain.Entities;
using Cadastros.Domain.IRepositories;
using Cadastros.Infra.Data.Context;

namespace Cadastros.Infra.Data.Repositories
{
    public class UFRepository : BaseRepository<UF>, IUFRepository
    {
        private readonly SQLServerContext _context;
        public UFRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
