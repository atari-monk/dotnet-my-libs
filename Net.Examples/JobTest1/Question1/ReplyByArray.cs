namespace Net.Examples;

public class ReplyByArray : ReplyForQ1
{
    protected override void PrintReply()
    {
        Console.WriteLine("Replay {0}: By {1}.", 7, "array");
    }

    protected override void ComputeResult()
    {
        var result = AddMultiply(a, b);
        PrintResult(result[0], result[1]);
    }

    private int[] AddMultiply(int a, int b)
    {
        return new int[] { a + b, a * b };
    }
}
