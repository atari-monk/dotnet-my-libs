namespace Net.Examples;

public class ReplyByList : ReplyForQ1
{
    protected override void PrintReply()
    {
        Console.WriteLine("Replay {0}: By {1}.", 8, "list");
    }

    protected override void ComputeResult()
    {
        var result = AddMultiply(a, b);
        PrintResult(result[0], result[1]);
    }
    
    private List<int> AddMultiply(int a, int b)
    {
        return new List<int> { a + b, a * b };
    }
}
