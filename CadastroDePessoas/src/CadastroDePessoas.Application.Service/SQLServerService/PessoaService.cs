using CadastroDePessoas.Domain.DTO;
using CadastroDePessoas.Domain.IRepositories;
using CadastroDePessoas.Domain.ISevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas.Application.Service.SQLServerService
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _repository;

        public PessoaService(IPessoaRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Save(PessoaDTO entity)
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
        public List<PessoaDTO> FindAll()
        {
            return _repository.FindAll()
                              .Select(c => new PessoaDTO()
                              {
                                  id = c.Id,
                                  nome = c.Nome,
                                  cpf = c.CPF,
                                  cidade= c.Cidade,
                                  dataNascimento= c.DataNascimento,
                              }).ToList();
        }
        public async Task<PessoaDTO> FindById(int id)
        {
            var dto = new PessoaDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }
    }
}
