namespace Net.Examples;

public class ReplyByOut : ReplyForQ1
{
    protected override void PrintReply()
    {
        Console.WriteLine("Replay {0}: By {1}.", 2, "out");
        Console.WriteLine("Many params in method lowers readability.");
    }

    protected override void ComputeResult()
    {
        int add = 0;
        int multiply = 0;
        AddMultiply(a, b, out add, out multiply);
        PrintResult(add, multiply);
    }

    private void AddMultiply(int a, int b, out int add, out int multiply)
    {
        add = a + b;
        multiply = a * b;
    }
}
