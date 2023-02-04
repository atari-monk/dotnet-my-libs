using Better.Console.Tables.Wrapper;
using BetterConsoles.Tables.Configuration;
using Cli = System.Console;

namespace Better.Console.Tables.TestApp;

public class TablesPrintout 
    : IExample
{
    private readonly IDictionary<string, IBetterTable<LogModel>> tables;
    private readonly ILogModelData data;

    public TablesPrintout(
        IDictionary<string, IBetterTable<LogModel>> tables
        , ILogModelData data)
    {
        this.tables = tables;
        this.data = data;
    }

    public void Run()
    {
        var logTable = tables[nameof(LogTable)];

        Cli.WriteLine("Default, no InnerRows");
        logTable.Table.Config.hasInnerRows = false;
        Cli.WriteLine(logTable.GetText(data.Data));
        logTable.Table.Config.hasInnerRows = true;

        Cli.WriteLine("Default");
        Cli.WriteLine(logTable.GetText(data.Data));

        var logTable2 = tables[nameof(LogTable2)];
        Cli.WriteLine("Default, headers & rows alignment center");
        Cli.WriteLine(logTable2.GetText(data.Data));

        Cli.WriteLine("Unicode style");
        logTable2.Table.Config = TableConfig.Unicode();
        Cli.WriteLine(logTable2.GetText(data.Data));

        Cli.WriteLine("UnicodeAlt style");
        logTable2.Table.Config = TableConfig.UnicodeAlt();
        Cli.WriteLine(logTable2.GetText(data.Data));

        Cli.WriteLine("Simple style");
        logTable2.Table.Config = TableConfig.Simple();
        Cli.WriteLine(logTable2.GetText(data.Data));

        Cli.WriteLine("MySql style");
        logTable2.Table.Config = TableConfig.MySql();
        Cli.WriteLine(logTable2.GetText(data.Data));

        Cli.WriteLine("MySqlSimple style");
        logTable2.Table.Config = TableConfig.MySqlSimple();
        Cli.WriteLine(logTable2.GetText(data.Data));

        Cli.WriteLine("Markdown style");
        logTable2.Table.Config = TableConfig.Markdown();
        Cli.WriteLine(logTable2.GetText(data.Data));

        var logTable3 = tables[nameof(LogTable3)];
        Cli.WriteLine("Advanced table");
        logTable3.Table.Config = TableConfig.Unicode();
        Cli.WriteLine(logTable3.GetText(data.Data));
    }
}