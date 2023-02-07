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
    public class TelefoneRepository : BaseRepository<Telefones>, ITelefoneRepository
    {
        private readonly SQLServerContext _context;
        public TelefoneRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
