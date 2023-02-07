namespace Net.Examples;

public class ReplyByStruct : ReplyForQ1
{
    struct Result
    {
        public int add;
        public int multiply;
    }

    protected override void PrintReply()
    {
        Console.WriteLine("Replay {0}: By {1}.", 3, "struct");
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
