using Cadastros.Domain.DTO;
using Cadastros.Domain.Entities;
using Cadastros.Domain.IRepositories;
using Cadastros.Domain.IServices;
using System.Collections.Generic;

namespace Cadastros.Application.Service.SQLServerServices
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _repository;
        private readonly IEmpresaRepository _empresaRepository;
        public FornecedorService(IFornecedorRepository repository, IEmpresaRepository empresaRepository)
        {
            _repository = repository;
            _empresaRepository = empresaRepository;
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
        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }
        public List<FornecedorDTO> FindAll()
        {
            return _repository.FindAll()
                  .Select(c => new FornecedorDTO()
                  {
                      id = c.Id,
                      empresaId = c.EmpresaId,
                      nome = c.Nome,
                      cpf_cnpj = c.CPF_CNPJ,
                      rg = c.RG

                  }).ToList();
        }
        public async Task<FornecedorDTO> FindById(int id)
        {
            var dto = new FornecedorDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }
        public List<FornecedorDTO>? FindByEmpresaId(int empresaId)
        {
            var dto = new List<FornecedorDTO>();
            dto = _repository.FindByEmpresaId(empresaId)
                                .Select(c => new FornecedorDTO()
                                {
                                    id = c.Id,
                                    empresaId = c.EmpresaId,
                                    nome = c.Nome,
                                    cpf_cnpj = c.CPF_CNPJ,
                                    rg = c.RG
                                }).ToList();
            return dto;
        }
    }
}

