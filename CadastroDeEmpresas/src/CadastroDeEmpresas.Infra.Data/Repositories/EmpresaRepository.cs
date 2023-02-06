using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeEmpresas.Domain.Entities;
using CadastroDeEmpresas.Domain.IRrepositories;
using CadastroDeEmpresas.Infra.Data.Context;

namespace CadastroDeEmpresas.Infra.Data.Repositories
{
    public class EmpresaRepository : BaseRepository<Empresa>, IEmpresaRepository
    {
        private readonly SQLServerContext _context;
        public EmpresaRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
