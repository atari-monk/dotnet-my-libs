namespace Net.Examples;

public abstract class ReplyForQ1 : IReply
{
    protected int a;
    protected int b;

    public ReplyForQ1()
    {
        a = 10;
        b = 20;
    }

    public void GetReply()
    {
        PrintReply();
        Console.WriteLine("a = {0}, b = {1}", a, b);
        ComputeResult();
    }

    protected abstract void PrintReply();

    protected abstract void ComputeResult();

    protected void PrintResult(int add, int multiply) =>
        Console.WriteLine("add = {0}, multiply = {1}", add, multiply);
}
