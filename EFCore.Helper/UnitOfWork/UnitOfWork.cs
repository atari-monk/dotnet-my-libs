using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace EFCore.Helper;

public abstract class UnitOfWork
  : UnitOfWorkDisposer
        , IUnitOfWork
{
  protected UnitOfWork(DbContext context)
      : base(context)
  {
  }

  public void Save() =>
  Context.SaveChanges();

  public IDbContextTransaction BeginTransaction() =>
      Context.Database.BeginTransaction();
}