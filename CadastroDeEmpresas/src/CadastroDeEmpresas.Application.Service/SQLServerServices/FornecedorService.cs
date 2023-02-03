using CadastroDeEmpresas.Domain.DTO;
using CadastroDeEmpresas.Domain.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeEmpresas.Application.Service.SQLServerServices
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
