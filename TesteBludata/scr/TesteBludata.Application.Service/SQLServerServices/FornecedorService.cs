using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBludata.Domain.DTO;
using TesteBludata.Domain.IService;

namespace TesteBludata.Application.Service.SQLServerServices
{
    public class FornecedorService : IFornecedorService
    {
        public Task<int> Creat(FornecedorDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<FornecedorDTO> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Task<FornecedorDTO> ReadById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
