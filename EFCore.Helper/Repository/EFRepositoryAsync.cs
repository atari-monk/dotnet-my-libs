using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EFCore.Helper;

public class EFRepositoryAsync<TEntity, TContext>
    : EFRepository<TEntity, TContext>
        , IEFRepositoryAsync<TEntity>
            where TEntity
                : class
                , new()
            where TContext
                : DbContext
{
  public EFRepositoryAsync(TContext context)
      : base(context)
  {
  }

  public async virtual Task<IEnumerable<TEntity>> GetAsync(
      Expression<Func<TEntity, bool>>? filter = null
      , Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null
      , string includeProperties = "")
  {
    IQueryable<TEntity> query = DbSet;

    if (filter != null)
    {
      query = query.Where(filter);
    }

    foreach (var includeProperty in includeProperties.Split
        (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
    {
      query = query.Include(includeProperty);
    }

    if (orderBy != null)
    {
      return await orderBy(query).ToListAsync();
    }
    else
    {
      return await query.ToListAsync();
    }
  }

  public async virtual Task<TEntity?> GetByIdAsync(object id)
  {
    return await DbSet.FindAsync(id);
  }

  public async virtual Task InsertAsync(TEntity entity)
  {
    await DbSet.AddAsync(entity);
  }

  public async virtual Task<bool> DeleteAsync(object id)
  {
    TEntity? entity = await DbSet.FindAsync(id);
    if (entity == null)
      return false;
    Delete(entity);
    return true;
  }
}