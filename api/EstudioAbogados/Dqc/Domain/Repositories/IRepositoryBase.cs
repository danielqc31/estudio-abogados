using Dqc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Dqc.Domain.Repositories
{
    public interface IRepositoryBase<TEntity, TPrimaryKey> where TEntity : class, IEntityBase<TPrimaryKey>
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] propertySelectors);
        List<TEntity> GetAllList();
        Task<List<TEntity>> GetAllListAsync();
        List<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetAllListAsync(Expression<Func<TEntity, bool>> predicate);
        TEntity FirstOrDefault(TPrimaryKey id);
        Task<TEntity> FirstOrDefaultAsync(TPrimaryKey id);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        // TEntity Load(TPrimaryKey id);

        TEntity Insert(TEntity entity);
        Task<TEntity> InsertAsync(TEntity entity);
        TPrimaryKey InsertAndGetId(TEntity entity);
        Task<TPrimaryKey> InsertAndGetIdAsync(TEntity entity);
        void Insert(IEnumerable<TEntity> entities);
        Task InsertAsync(IEnumerable<TEntity> entities);

        TEntity Update(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);

        void Delete(TEntity entity);
        Task DeleteAsync(TEntity entity);
        void Delete(TPrimaryKey id);
        Task DeleteAsync(TPrimaryKey id);

        int Count();
        Task<int> CountAsync();
        int Count(Expression<Func<TEntity, bool>> predicate);
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);
    }

    public interface IRepositoryBase<TEntity> : IRepositoryBase<TEntity, int> where TEntity : class, IEntityBase<int>
    {
    }
}
