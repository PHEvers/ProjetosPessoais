using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBludata.Domain.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<int> Create(T entity);
        Task<T> ReadById(int id);
        IQueryable<T> ReadAll();
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
    }
}
