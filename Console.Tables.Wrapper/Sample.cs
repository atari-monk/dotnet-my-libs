namespace Console.Tables.Wrapper;

public class Sample
{
    public Sample()
    {
        Id = Guid.NewGuid().ToString("N");
        Name = "Planet earth";
        Date = DateTime.Now;
    }

    public string Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public int PopulationNumber { get; set; }
}