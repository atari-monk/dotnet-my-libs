using Microsoft.EntityFrameworkCore.Storage;

namespace EFCore.Helper;

public interface ITransactionAsync
{
  Task<IDbContextTransaction> BeginTransactionAsync(
      CancellationToken cancellationToken = default);
}