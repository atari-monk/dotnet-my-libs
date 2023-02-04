using System.Drawing;
using BetterConsoles.Tables;
using BetterConsoles.Tables.Builders;
using BetterConsoles.Tables.Models;

namespace Better.Console.Tables.Wrapper;

public class LogTable3
    : LogTable
{
    public LogTable3()
    {
        var headerFormat = new CellFormat()
        {
            Alignment = Alignment.Center,
            ForegroundColor = Color.Magenta
        };
        Table = new TableBuilder(headerFormat)
            .AddColumn(nameof(LogModel.Id), rowsFormat: new CellFormat(foregroundColor: Color.FromArgb(255, 255, 0)))
            .AddColumn(nameof(LogModel.Task))
                .RowsFormat()
                    .ForegroundColor(Color.FromArgb(0, 255, 0))
            .AddColumn(nameof(LogModel.Description))
                .RowsFormat()
                    .ForegroundColor(Color.FromArgb(255, 255, 255))
            .AddColumn(nameof(LogModel.Category))
                .RowsFormat()
                    .ForegroundColor(Color.FromArgb(0, 0, 255))
            .AddColumn(nameof(LogModel.Start))
                .RowsFormat()
                    .Alignment(Alignment.Right)
                    .BackgroundColor(Color.ForestGreen)
                    .ForegroundColor(Color.DarkGray)
            .Build();
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
                );
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
            list.Add(new[] {
                item.Id.ToString()
                , item.Task
                , item.Description
                , item.Category
                , item.Start.ToString()
                });
        }
        return list;
    }
}