namespace Net.Examples;

public class ReplyQ2 : IReply
{
    public void GetReply()
    {
        ClassA ab = new ClassB();
        ab.Method1();
        ab.Method2();
    }
}

public class ClassA
{
    public virtual void Method1() => Console.WriteLine("A1");
    public virtual void Method2() => Console.WriteLine("A2");
}

public class ClassB : ClassA
{
    public override void Method1() => Console.WriteLine("B1");
    public new void Method2() => Console.WriteLine("B2");
}