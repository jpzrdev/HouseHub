using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharedKernel.Repository
{
    public interface IBaseRepository<T>
    {
        Task<T> GetByIdAsync(Guid id);
        IQueryable<T> GetAll();
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task SaveChangesAsync();
    }
}