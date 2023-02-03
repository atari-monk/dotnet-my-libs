using Microsoft.EntityFrameworkCore.Storage;

namespace EFCore.Helper;

public interface ITransaction
{
    IDbContextTransaction BeginTransaction();
}