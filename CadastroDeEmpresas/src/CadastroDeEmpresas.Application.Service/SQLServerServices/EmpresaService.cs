using CadastroDeEmpresas.Domain.DTO;
using CadastroDeEmpresas.Domain.IRrepositories;
using CadastroDeEmpresas.Domain.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeEmpresas.Application.Service.SQLServerServices
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
                      nomeFantasia = c.NomeFantasia
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
