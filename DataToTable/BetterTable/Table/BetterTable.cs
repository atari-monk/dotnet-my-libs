using System.Drawing;
using BetterConsoles.Tables;
using BetterConsoles.Tables.Builders;
using BetterConsoles.Tables.Models;

namespace Better.Console.Tables.Wrapper;

public abstract class BetterTable<TEntity>
    : BetterTableApi<TEntity>
{
    protected void BuildColumn(
        TableBuilder builder
        , string propName
        , Color headerColor
        , Color rowColor
        , Alignment headerAlignment = Alignment.Center
        , Alignment rowAlignment = Alignment.Center)
    {
        var headerFormat = new CellFormat(alignment:headerAlignment, foregroundColor: headerColor);
        var rowFormat = new CellFormat(alignment:rowAlignment, foregroundColor: rowColor);
        builder
            .AddColumn(propName)
                .HeaderFormat(headerFormat)
                .RowsFormat(rowFormat);
    }

    protected void BuildColumn(
        TableBuilder builder
        , string propName
        , Color color
        , Alignment alignment = Alignment.Center)
    {
        BuildColumn(builder, propName, color, color, alignment, alignment);
    }

    protected void BuildColumn(
        TableBuilder builder
        , string propName
        , Alignment alignment = Alignment.Center)
    {
        BuildColumn(builder, propName, Color.White, Color.White, alignment, alignment);
    }
}