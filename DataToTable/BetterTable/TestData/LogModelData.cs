namespace Better.Console.Tables.Wrapper;

public class LogModelData
    : ILogModelData
{
    public List<LogModel> Data =>
        new List<LogModel>
        {
            new LogModel()
            {
                Id = 1
                , Task = "Watering"
                , Description = "With fertilizer"
                , Category = "Gardening"
                , Start = new DateTime(2022, 8, 13, 16, 50 , 0)
                , End = new DateTime(2022, 8, 13, 17, 50 , 0)
                , Time = new TimeSpan(1, 0, 0)
                , Place = "Zabiniec"
                , Price = 10
            },
            new LogModel()
            {
                Id = 2
                , Task = "Writing code"
                , Description = "Table lib"
                , Category = "Coding"
                , Start = new DateTime(2022, 8, 13, 17, 50 , 0)
                , End = new DateTime(2022, 8, 13, 18, 50 , 0)
                , Time = new TimeSpan(1, 0, 0)
                , Place = "Zabiniec"
                , Price = -10
            }
        };
}