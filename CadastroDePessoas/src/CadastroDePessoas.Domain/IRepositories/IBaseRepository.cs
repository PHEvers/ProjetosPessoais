namespace Cadastros.Domain.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<int> Save(T entity);
        IQueryable<T> FindAll();
        Task<T> FindById(int id);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
    }
}
