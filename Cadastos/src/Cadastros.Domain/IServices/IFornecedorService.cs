using Cadastros.Domain.DTO;

namespace Cadastros.Domain.IServices
{
    public interface IFornecedorService : IBaseService<FornecedorDTO>
    {
        List<FornecedorDTO>? FindByEmpresaId(int empresaId);
    }
}
