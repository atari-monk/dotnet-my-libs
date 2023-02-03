using System.Linq.Expressions;

namespace EFCore.Helper;

public interface IRepository<TEntity> 
    where TEntity : class
{
    IEnumerable<TEntity> Get(
        Expression<Func<TEntity, bool>>? filter = null
        , Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null
        , string includeProperties = "");

    TEntity? GetById(object id);

    void Insert(TEntity entity);

    void Update(TEntity entity);

    bool Delete(object id);

    void Delete(TEntity entity);
}