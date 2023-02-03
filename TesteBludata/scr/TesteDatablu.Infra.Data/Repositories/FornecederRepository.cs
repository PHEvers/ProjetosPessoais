using TesteBludata.Domain.IRepositories;
using TesteBludata.Domain.Entities;
using TesteBludata.Domain.IRrepositories;
using TesteDatablu.Infra.Data.Context;

namespace TesteBludata.Infra.Data.Repositories
{
    public class FornecedorRepository : BaseRepository<Fornecedor>, IFornecedorRepository
    {
        private readonly SQLServerContext _context;
        public FornecedorRepository(SQLServerContext context) : base(context)
        {
            this._context = context;
        }
    }
}
