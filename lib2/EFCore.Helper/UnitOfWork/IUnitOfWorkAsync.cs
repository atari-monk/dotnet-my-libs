namespace EFCore.Helper;

public interface IUnitOfWorkAsync
    : IUnitOfWork
        , ITransactionAsync
{
    Task SaveAsync();
}