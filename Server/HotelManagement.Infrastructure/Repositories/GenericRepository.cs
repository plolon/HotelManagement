using HotelManagement.Domain.Repositories;

namespace HotelManagement.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
