using CadastroDeEmpresas.Domain.DTO;
using CadastroDeEmpresas.Domain.IRrepositories;
using CadastroDeEmpresas.Domain.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeFornecedors.Application.Service.SQLServerServices
{
    public class FornecedorService : IFornecedorService
    {

        private readonly IFornecedorRepository _repository;
        public FornecedorService(IFornecedorRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Save(FornecedorDTO entity)
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
        public List<FornecedorDTO> FindAll()
        {
            return _repository.FindAll()
                  .Select(c => new FornecedorDTO()
                  {
                      id = c.Id,
                      nome = c.Nome
                  }).ToList();
        }
        public async Task<FornecedorDTO> FindById(int id)
        {
            var dto = new FornecedorDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }
    }
}
