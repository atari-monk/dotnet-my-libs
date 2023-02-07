namespace Net.Examples;

public class ReplyByDictionary : ReplyForQ1
{
    protected override void PrintReply()
    {
        Console.WriteLine("Replay {0}: By {1}.", 9, "dictionary");
    }

    protected override void ComputeResult()
    {
        var result = AddMultiply(a, b);
        PrintResult(result["add"], result["multiply"]);
    }

    private Dictionary<string, int> AddMultiply(int a, int b)
    {
        return new Dictionary<string, int> { 
            { "add", a + b }
            , { "multiply", a * b } 
        };
    }
}