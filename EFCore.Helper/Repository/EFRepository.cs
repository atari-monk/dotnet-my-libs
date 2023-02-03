using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EFCore.Helper;

public class EFRepository<TEntity, TContext>
	: IRepository<TEntity>
		where TEntity : class, new()
		where TContext : DbContext
{
	protected readonly TContext Context;
	protected readonly DbSet<TEntity> DbSet;

	public EFRepository(TContext context)
	{
		this.Context = context;
		DbSet = context.Set<TEntity>();
	}

	public virtual IEnumerable<TEntity> Get(
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
			return orderBy(query).ToList();
		}
		else
		{
			return query.ToList();
		}
	}

	public virtual TEntity? GetById(object id)
	{
		return DbSet.Find(id);
	}

	public virtual void Insert(TEntity entity)
	{
		DbSet.Add(entity);
	}

	public virtual void Update(TEntity entityToUpdate)
	{
		DbSet.Attach(entityToUpdate);
		Context.Entry(entityToUpdate).State = EntityState.Modified;
	}

	public virtual bool Delete(object id)
	{
		TEntity? entity = DbSet.Find(id);
		if(entity == null)
            return false;
		Delete(entity);
        return true;
	}

	public virtual void Delete(TEntity entity)
	{
		if (Context.Entry(entity).State == EntityState.Detached)
		{
			DbSet.Attach(entity);
		}
		DbSet.Remove(entity);
	}
}