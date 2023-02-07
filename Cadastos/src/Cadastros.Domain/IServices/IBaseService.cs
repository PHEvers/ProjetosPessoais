namespace Cadastros.Domain.IServices
{
    public interface IBaseService<T> where T : class
    {
        Task<int> Save(T entity);
        List<T> FindAll();
        Task<T> FindById(int id);
        Task<int> Delete(int id);
    }
}
