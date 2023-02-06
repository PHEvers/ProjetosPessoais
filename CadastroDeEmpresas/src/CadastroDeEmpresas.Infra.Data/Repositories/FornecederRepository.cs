using CadastroDeEmpresas.Domain.IRepositories;
using CadastroDeEmpresas.Domain.Entities;
using CadastroDeEmpresas.Domain.IRrepositories;
using CadastroDeEmpresas.Infra.Data.Context;

namespace CadastroDeEmpresas.Infra.Data.Repositories
{
    public class FornecedorRepository : BaseRepository<Fornecedor>, IFornecedorRepository
    {
        private readonly SQLServerContext _context;
        public FornecedorRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
