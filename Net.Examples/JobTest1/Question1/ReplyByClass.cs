namespace Net.Examples;

public class ReplyByClass : ReplyForQ1
{
    class  Result
    {
        public int add;
        public int multiply;
    }

    protected override void PrintReply()
    {
        Console.WriteLine("Replay {0}: By {1}.", 4, "class");
    }

    protected override void ComputeResult()
    {
        var result = AddMultiply(a, b);
        PrintResult(result.add, result.multiply);
    }

    private Result AddMultiply(int a, int b)
    {
        var result = new Result
        {
            add = a + b,
            multiply = a * b
        };
        return result;
    }
}
