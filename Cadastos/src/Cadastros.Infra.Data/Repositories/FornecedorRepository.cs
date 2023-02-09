using Cadastros.Domain.DTO;
using Cadastros.Domain.Entities;
using Cadastros.Domain.IRepositories;
using Cadastros.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.Infra.Data.Repositories
{
    public class FornecedorRepository : BaseRepository<Fornecedor>, IFornecedorRepository
    {
        private readonly SQLServerContext _contextFornecedor;

        public FornecedorRepository(SQLServerContext context) : base(context)
        {
            _contextFornecedor = context;
        }
        public IEnumerable<Fornecedor>? FindByEmpresaId(int empresaId)
        {
            return _contextFornecedor.Fornecedors.Where(p => p.EmpresaId == empresaId);
        }
    }
}
