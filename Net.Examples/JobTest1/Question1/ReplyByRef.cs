namespace Net.Examples;

public class ReplyByRef : ReplyForQ1
{
    protected override void PrintReply()
    {
        Console.WriteLine("Replay {0}: By {1}.", 1, "ref");
        Console.WriteLine("Many params in method lowers readability.");
    }

    protected override void ComputeResult()
    {
        int add = 0;
        int multiply = 0;
        AddMultiply(a, b, ref add, ref multiply);
        PrintResult(add, multiply);
    }

    private void AddMultiply(int a, int b, ref int add, ref int multiply)
    {
        add = a + b;
        multiply = a * b;
    }
}
