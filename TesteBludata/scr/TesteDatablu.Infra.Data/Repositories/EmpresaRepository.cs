using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBludata.Domain.Entities;
using TesteBludata.Domain.IRrepositories;
using TesteDatablu.Infra.Data.Context;

namespace TesteBludata.Infra.Data.Repositories
{
    public class EmpresaRepository : BaseRepository<Empresa>, IEmpresaRepository
    {
        private readonly SQLServerContext _context;
        public EmpresaRepository(SQLServerContext context) : base(context)
        {
            this._context = context;
        }
    }
}
