using BaseVersion.Repository.DbConfigure;
using BaseVersion.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseVersion.Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly HRMDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(HRMDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        //public async Task<IEnumerable<T>> GetAllAsync()
        //{
        //    return await _dbSet.ToListAsync();
        //}

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dbSet;

            // Apply each include to the query
            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return await query.ToListAsync();
        }

        public IQueryable<T> GetAllAsyncQuery()
        {
            return _dbSet;
        }

        //public async Task<T> GetByIdAsync(int id)
        //{
        //    return await _dbSet.FindAsync(id);
        //}

        public async Task<T> GetByIdAsync(string id)
        {
            return await _dbSet.AsNoTracking().FirstOrDefaultAsync(e => EF.Property<string>(e, "Id") == id);
        }
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task AddAsyncWithTransaction(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsyncWithTransaction(T entity)
        {
            _dbSet.Update(entity);
        }
        public async Task DeleteAsync(string id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteByMomIdAsync(string momId)
        {
            var entities = await _dbSet.Where(x => EF.Property<string>(x, "MomId") == momId).ToListAsync();

            if (entities != null)
            {
                _dbSet.RemoveRange(entities);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteByMomIdAsyncWithTransaction(string momId)
        {
            var entities = await _dbSet.Where(x => EF.Property<string>(x, "MomId") == momId).ToListAsync();

            if (entities != null)
            {
                _dbSet.RemoveRange(entities);
            }
        }

        public async Task DeleteAsyncWithTransaction(string id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public async Task SaveChangesAsyncWithTransaction()
        {
            await _context.SaveChangesAsync();
        }

        public async Task BeginTransactionAsync()
        {
           await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            await _context.Database.CommitTransactionAsync();
        }

        public async Task RollbackTransactionAsync()
        {
            await _context.Database.RollbackTransactionAsync();
        }
    }

}
