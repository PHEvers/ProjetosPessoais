using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBludata.Domain.Entities;
using TesteBludata.Domain.IRepositories;
using TesteDatablu.Infra.Data.Context;

namespace TesteBludata.Infra.Data.Repositories
{
    public class UFRepository : BaseRepository<UF>, IUFRepository
    {
        private readonly SQLServerContext _context;
        public UFRepository(SQLServerContext context) : base(context)
        {

        }
    }
}
