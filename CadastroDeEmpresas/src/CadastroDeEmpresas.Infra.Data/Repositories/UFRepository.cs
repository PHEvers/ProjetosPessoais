using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeEmpresas.Domain.Entities;
using CadastroDeEmpresas.Domain.IRepositories;
using CadastroDeEmpresas.Infra.Data.Context;

namespace CadastroDeEmpresas.Infra.Data.Repositories
{
    public class UFRepository : BaseRepository<UF>, IUFRepository
    {
        private readonly SQLServerContext _context;
        public UFRepository(SQLServerContext context) : base(context)
        {

        }
    }
}
