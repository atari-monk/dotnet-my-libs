using System.Linq.Expressions;

namespace EFCore.Helper;

public interface IEFRepositoryAsync<TEntity>
    : IRepository<TEntity>
        where TEntity 
            : class
            , new()
{
    Task<bool> DeleteAsync(object id);
    
    Task<IEnumerable<TEntity>> GetAsync(
        Expression<Func<TEntity, bool>>? filter = null
        , Func<IQueryable<TEntity>
        , IOrderedQueryable<TEntity>>? orderBy = null
        , string includeProperties = "");
    
    Task<TEntity?> GetByIdAsync(object id);
    
    Task InsertAsync(TEntity entity);
}