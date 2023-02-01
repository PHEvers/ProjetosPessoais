using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBludata.Domain.DTO;
using TesteBludata.Domain.IRepositories;
using TesteBludata.Domain.IService;


namespace TesteBludata.Application.Service.SQLServerServices
{
    public class UFService : IUFService
    {
        private readonly IUFRepository _repository;
        public UFService(IUFRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Creat(UFDTO entity)
        {
            if (entity.id > 0)
            {
                return _repository.Update(entity.mapToEntity());
            }
            else
            {
                return _repository.Save(entity.mapToEntity());
            }
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<UFDTO> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Task<UFDTO> ReadById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
