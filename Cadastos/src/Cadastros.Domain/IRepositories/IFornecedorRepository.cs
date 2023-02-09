using Cadastros.Domain.Entities;

namespace Cadastros.Domain.IRepositories
{
    public interface IFornecedorRepository : IBaseRepository<Fornecedor>
    {
        IEnumerable<Fornecedor> FindByEmpresaId(int empresaId);
    }
}
