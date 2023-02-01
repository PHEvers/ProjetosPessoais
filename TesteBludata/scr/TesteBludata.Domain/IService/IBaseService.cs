using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBludata.Domain.IService
{
    public interface IBaseService<T> where T : class
    {
        Task<int> Creat(T entity);
        List<T> ReadAll();
        Task<T> ReadById(int id);
        Task<int> Delete(int id);
    }
}
