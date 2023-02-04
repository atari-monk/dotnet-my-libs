using BetterConsoles.Tables;
using DataToTable;

namespace Better.Console.Tables.Wrapper;

public interface IBetterTable<TEntity>
    : IDataToText<TEntity>
{
    public Table Table { get; }

    string GetTableWithAddedData(List<TEntity> items);
}