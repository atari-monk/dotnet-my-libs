namespace Better.Console.Tables.Wrapper;

public class LogModel
{
    public int Id { get; set; }

    public string? Task { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; }

    public DateTime Start { get; set; }

    public DateTime End { get; set; }

    public TimeSpan Time { get; set; }

    public string? Place { get; set; }

    public int Price { get; set; }
}