namespace Net.Examples;

public class ReplyByTupleVer7 : ReplyForQ1
{
    protected override void PrintReply()
    {
        Console.WriteLine("Replay {0}: By {1}.", 6, "tupleVer7");
    }

    protected override void ComputeResult()
    {
        var result = AddMultiply(a, b);
        PrintResult(result.Item1, result.Item2);
    }

    private (int add, int multiply) AddMultiply(int a, int b)
    {
        return(a + b, a * b);
    }
}
