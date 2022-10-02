﻿using HotelManagement.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly HotelManagementDbContext _dbContext;

        public GenericRepository(HotelManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<T> Get(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
        public async Task<ICollection<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }
        public async Task<T> Add(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();    // TODO implement unit of work pattern !important!
            return entity;
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }



        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
