using Cadastros.Domain.DTO;
using Cadastros.Domain.IRepositories;
using Cadastros.Domain.IServices;

namespace Cadastros.Application.Service.SQLServerServices
{
    public class TelefoneService : ITelefoneService
    {
        private readonly ITelefoneRepository _telefoneRepository;
        public TelefoneService(ITelefoneRepository repository, IFornecedorRepository fornecedorRepository)
        {
            _telefoneRepository = repository;
        }
        public Task<int> Save(TelefoneDTO entity)
        {
            if (entity.id > 0)
            {
                return _telefoneRepository.Update(entity.mapToEntity());
            }
            else
            {
                return _telefoneRepository.Save(entity.mapToEntity());
            }
        }
        public List<TelefoneDTO> FindAll()
        {
            return _telefoneRepository.FindAll()
                              .Select(c => new TelefoneDTO()
                              {
                                  id = c.Id,
                                  numero = c.Numero,
                                  fornecedorId = c.FornecedorId
                              }).ToList();
        }
        public async Task<TelefoneDTO> FindById(int id)
        {
            var dto = new TelefoneDTO();
            return dto.mapToDTO(await _telefoneRepository.FindById(id));
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _telefoneRepository.FindById(id);
            return await _telefoneRepository.Delete(entity);
        }
    }
}
