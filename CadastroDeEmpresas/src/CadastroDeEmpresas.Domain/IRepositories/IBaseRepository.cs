using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeEmpresas.Domain.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<int> Save(T entity);
        Task<T> FindById(int id);
        IQueryable<T> FindAll();
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
    }
}
