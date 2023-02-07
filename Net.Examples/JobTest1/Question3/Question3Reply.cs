namespace Net.Examples;

public class Question3Reply : QuestionReply
{
    protected override void PrintQuestion()
    {
        Console.WriteLine("Question 3: What will be on output");
    }

    protected override IReply[] GetReplies()
    {
        return new IReply[] 
        { 
            new ReplyQ3()
        };
    }
}