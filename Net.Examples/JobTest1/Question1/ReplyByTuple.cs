namespace Net.Examples;

public class ReplyByTuple : ReplyForQ1
{
    protected override void PrintReply()
    {
        Console.WriteLine("Replay {0}: By {1}.", 5, "tuple");
    }

    protected override void ComputeResult()
    {
        var result = AddMultiply(a, b);
        PrintResult(result.Item1, result.Item2);
    }

    private Tuple<int, int> AddMultiply(int a, int b)
    {
        var result = new Tuple<int, int>(a + b, a * b);
        return result;
    }
}
