using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseVersion.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
        Task SaveChangesAsyncWithTransaction();

        //Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includes);
        Task<T> GetByIdAsync(string id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(string id);

        Task DeleteByMomIdAsync(string momId);
        Task DeleteByMomIdAsyncWithTransaction(string momId);

        IQueryable<T> GetAllAsyncQuery();
         
        Task AddAsyncWithTransaction(T entity);
        Task UpdateAsyncWithTransaction(T entity);
        Task DeleteAsyncWithTransaction(string id);
    }

}
