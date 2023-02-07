namespace Net.Examples;

public class ReplyQ4 : IReply
{
    public void GetReply()
    {
        var x = 7;
        Method(x);
        Console.WriteLine("Result is :{0}", x);
    }

    void Method(int x)
    {
        x = x + 4;
    }
}
