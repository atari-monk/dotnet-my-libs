using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace EFCore.Helper;

public abstract class UnitOfWorkAsync
    : UnitOfWork
{
    protected UnitOfWorkAsync(DbContext context)
        : base(context)
    {
    }

    public async Task SaveAsync() => 
        await Context.SaveChangesAsync();
    
    public Task<IDbContextTransaction> BeginTransactionAsync(
        CancellationToken cancellationToken = default) => 
            Context.Database.BeginTransactionAsync(cancellationToken);
}
