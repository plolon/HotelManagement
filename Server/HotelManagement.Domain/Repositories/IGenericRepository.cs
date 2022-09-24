namespace HotelManagement.Domain.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<ICollection<T>> GetAll();
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<bool> Delete(int id);
    }
}
