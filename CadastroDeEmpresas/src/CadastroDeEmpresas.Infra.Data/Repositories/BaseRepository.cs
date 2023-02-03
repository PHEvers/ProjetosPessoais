using CadastroDeEmpresas.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeEmpresas.Infra.Data.Context;

namespace CadastroDeEmpresas.Infra.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly SQLServerContext _context;
        public BaseRepository(SQLServerContext context)
        {
            this._context = context;
        }
        public Task<int> Create(T entity)
        {
            this._context.Set<T>().Add(entity);
            return this._context.SaveChangesAsync();
        }
        public async Task<T> ReadById(int id)
        {
            return await this._context.Set<T>().FindAsync(id);
        }
        public IQueryable<T> ReadAll()
        {
            return this._context.Set<T>(); ;
        }
        public Task<int> Update(T entity)
        {
            try
            {
                this._context.Set<T>().Update(entity);
                return this._context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var text = ex.Message;
                return this._context.SaveChangesAsync();
            }
        }
        public Task<int> Delete(T entity)
        {
            this._context.Set<T>().Remove(entity);
            return this._context.SaveChangesAsync();
        }
    }
}
