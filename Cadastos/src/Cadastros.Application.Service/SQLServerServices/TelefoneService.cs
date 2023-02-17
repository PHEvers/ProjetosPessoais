using Cadastros.Domain.DTO;
using Cadastros.Domain.IRepositories;
using Cadastros.Domain.IServices;

namespace Cadastros.Application.Service.SQLServerServices
{
    public class TelefoneService : ITelefoneServices
    {
        private readonly ITelefoneRepository _repository;
        private readonly IFornecedorRepository _fornecedorRepository;
        public TelefoneService(ITelefoneRepository repository, IFornecedorRepository fornecedorRepository)
        {
            _repository = repository;
            _fornecedorRepository = fornecedorRepository;
        }
        public Task<int> Save(TelefoneDTO entity)
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
        public List<TelefoneDTO> FindAll()
        {
            return _repository.FindAll()
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
            return dto.mapToDTO(await _repository.FindById(id));
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }
    }
}
