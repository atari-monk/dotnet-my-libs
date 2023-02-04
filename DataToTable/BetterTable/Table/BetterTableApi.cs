using BetterConsoles.Tables;

namespace Better.Console.Tables.Wrapper;

public abstract class BetterTableApi<TEntity>
    : IBetterTable<TEntity>
{
    public Table Table { get; protected set; }

    public BetterTableApi()
    {
        Table = new Table();
    }

    public string GetText(List<TEntity> items)
    {
        if(items != null && items.Count > 0)
            Table.ReplaceRows(ConvertData(items));
        return Table.ToString();
    }

    public string GetTableWithAddedData(List<TEntity> items)
    {
        if(items != null && items.Count > 0)
            AddRowsToTable(items);
        return Table.ToString();
    }

    protected abstract List<object[]> ConvertData(IEnumerable<TEntity> items);
    
    protected abstract void AddRowsToTable(IEnumerable<TEntity> items);
}