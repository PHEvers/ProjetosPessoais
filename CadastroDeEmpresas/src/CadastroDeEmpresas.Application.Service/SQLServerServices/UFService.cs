using CadastroDeEmpresas.Domain.DTO;
using CadastroDeEmpresas.Domain.IRepositories;
using CadastroDeEmpresas.Domain.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeEmpresas.Application.Service.SQLServerServices
{
    public class UFService : IUFService
    {
        private readonly IUFRepository _repository;
        public UFService(IUFRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Save(UFDTO entity)
        {
            // Já foram criados todos os estados em namespace CadastroDeEmpresas.Infra.Data.Context
            throw new NotImplementedException();
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
        public Task<int> Delete(int id)
        {
            // também não precisa implementar, não será possivel excluir nenhum estado.
            throw new NotImplementedException();
        }
    }
}
