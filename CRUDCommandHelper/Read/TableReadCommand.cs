using Better.Console.Tables.Wrapper;
using CLIHelper;
using EFCore.Helper;
using Serilog;

namespace CRUDCommandHelper;

public abstract class TableReadCommand<TUnitOfWork, TEntity, TArgumentModel>
    : IReadCommand<TArgumentModel>
        where TUnitOfWork : IUnitOfWork
{
    protected readonly TUnitOfWork UnitOfWork;
    protected readonly IOutput Output;
    protected readonly ILogger Log;
    private readonly IDictionary<string, IBetterTable<TEntity>> tables;

    public TableReadCommand(
        TUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDictionary<string, IBetterTable<TEntity>> tables)
    {
        UnitOfWork = unitOfWork;
        this.Output = output;
        this.Log = log;
        this.tables = tables;
        ArgumentNullException.ThrowIfNull(UnitOfWork);
        ArgumentNullException.ThrowIfNull(this.Output);
        ArgumentNullException.ThrowIfNull(this.Log);
        ArgumentNullException.ThrowIfNull(this.tables);
    }

    public void Read(TArgumentModel model)
    {
        Output.Clear();
        Log.Information(
            "{0} {1}", nameof(Read), typeof(TEntity).Name);
        Output.Write(
            tables[GetTableKey(model)].GetText(
                Get(model)));
    }

    protected abstract string GetTableKey(TArgumentModel model);

    protected abstract List<TEntity> Get(TArgumentModel model);
}