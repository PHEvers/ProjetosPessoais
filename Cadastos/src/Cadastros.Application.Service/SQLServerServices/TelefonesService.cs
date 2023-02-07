using Cadastros.Domain.DTO;
using Cadastros.Domain.IRepositories;
using Cadastros.Domain.IServices;

namespace Cadastros.Application.Service.SQLServerServices
{
    public class TelefonesService : ITelefonesService
    {
        private readonly ITelefoneRepository _repository;
        public TelefonesService(ITelefoneRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Save(TelefonesDTO entity)
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
        public List<TelefonesDTO> FindAll()
        {
            return _repository.FindAll()
                  .Select(c => new TelefonesDTO()
                  {
                      id = c.Id,
                      numero = c.Numero,
                      fornecedorId = c.FornecedorId,
                  }).ToList();
        }
        public async Task<TelefonesDTO> FindById(int id)
        {
            var dto = new TelefonesDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }
    }
}
