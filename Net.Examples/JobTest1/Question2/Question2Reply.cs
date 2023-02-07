namespace Net.Examples;

public class Question2Reply : QuestionReply
{
    protected override void PrintQuestion()
    {
        Console.WriteLine("Question 2: What will be on output");
    }

    protected override IReply[] GetReplies()
    {
        return new IReply[] 
        { 
            new ReplyQ2()
        };
    }
}