using Cadastros.Domain.DTO;
using Cadastros.Domain.Entities;
using Cadastros.Domain.IRepositories;
using Cadastros.Domain.IServices;

namespace Cadastros.Application.Service.SQLServerServices
{
    public class UFService : IUFServices
    {
        private readonly IUFRepository _repository;
        public UFService(IUFRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Save(UFDTO entity)
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
        public List<UFDTO> FindAll()
        {
            return _repository.FindAll()
                  .Select(c => new UFDTO()
                  {
                      id = c.Id,
                      nome = c.Nome
                  }).ToList();
        }
        public async Task<UFDTO> FindById(int id)
        {
            var dto = new UFDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }
    }
}
