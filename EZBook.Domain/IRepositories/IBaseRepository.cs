using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Domain.IRepositories
{
    public interface IBaseRepository<T> where T : class 
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
