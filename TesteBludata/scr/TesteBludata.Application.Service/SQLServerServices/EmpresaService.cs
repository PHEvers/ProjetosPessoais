using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBludata.Domain.DTO;
using TesteBludata.Domain.IService;

namespace TesteBludata.Application.Service.SQLServerServices
{
    public class EmpresaService : IEmpresaService
    {
        public Task<int> Creat(EmpresaDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<EmpresaDTO> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Task<EmpresaDTO> ReadById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
