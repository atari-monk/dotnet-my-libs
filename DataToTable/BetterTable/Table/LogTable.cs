using BetterConsoles.Tables;

namespace Better.Console.Tables.Wrapper;

public class LogTable
    : BetterTable<LogModel>
{
    public LogTable()
    {
        Table = new Table( 
            nameof(LogModel.Id)
            , nameof(LogModel.Task)
            , nameof(LogModel.Description)
            , nameof(LogModel.Category)
            , nameof(LogModel.Start)
            , nameof(LogModel.End)
            , nameof(LogModel.Time)
            , nameof(LogModel.Place));
    }

    protected override void AddRowsToTable(IEnumerable<LogModel> items)
    {
        foreach (var item in items)
        {
            Table.AddRow(
                item.Id
                , item.Task
                , item.Description
                , item.Category
                , item.Start
                , item.End
                , item.Time
                , item.Place);
        }
    }

    protected override List<object[]> ConvertData(IEnumerable<LogModel> items)
    {
        var list = new List<object[]>();
        foreach (var item in items)
        {
            ArgumentNullException.ThrowIfNull(item.Task);
            ArgumentNullException.ThrowIfNull(item.Description);
            ArgumentNullException.ThrowIfNull(item.Category);
            ArgumentNullException.ThrowIfNull(item.Place);
            list.Add(new [] { 
                item.Id.ToString()
                , item.Task
                , item.Description
                , item.Category
                , item.Start.ToString()
                , item.End.ToString()
                , item.Time.ToString()
                , item.Place });
        }
        return list;
    }
}