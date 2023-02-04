using BetterConsoles.Tables;

namespace Better.Console.Tables.Wrapper;

public class LogTable2
    : LogTable
{
    public LogTable2()
    {
        Table = new Table(
            Alignment.Center
            , Alignment.Center
            , nameof(LogModel.Id)
            , nameof(LogModel.Task)
            , nameof(LogModel.Description)
            , nameof(LogModel.Category)
            , nameof(LogModel.Start)
            , nameof(LogModel.End)
            , nameof(LogModel.Time)
            , nameof(LogModel.Place));
    }
}