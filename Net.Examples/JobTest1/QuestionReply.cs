namespace Net.Examples;

public abstract class QuestionReply : IReply
{
    private readonly IReply[] replies;

    public QuestionReply()
    {
        replies = GetReplies();
    }

    protected abstract IReply[] GetReplies(); 

    public void GetReply()
    {
        PrintQuestion();
        foreach (var reply in replies)
        {
            reply.GetReply();
        }
    }

    protected abstract void PrintQuestion();
}
