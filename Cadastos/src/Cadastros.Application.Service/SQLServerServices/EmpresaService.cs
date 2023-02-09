using Cadastros.Domain.DTO;
using Cadastros.Domain.IRepositories;
using Cadastros.Domain.IServices;

namespace Cadastros.Application.Service.SQLServerServices
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _repository;
        public EmpresaService(IEmpresaRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Save(EmpresaDTO entity)
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
        public List<EmpresaDTO> FindAll()
        {
            return _repository.FindAll()
                  .Select(c => new EmpresaDTO()
                  {
                      id = c.Id,
                      nomeFantasia = c.NomeFantasia,
                      cNPJ = c.CNPJ,
                      ufId = c.UFId,
                  }).ToList();
        }
        public async Task<EmpresaDTO> FindById(int id)
        {
            var dto = new EmpresaDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }
    }
}
