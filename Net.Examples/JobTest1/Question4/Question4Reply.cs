namespace Net.Examples;

public class Question4Reply : QuestionReply
{
    protected override void PrintQuestion()
    {
        Console.WriteLine("Question 4: What will be on output");
    }

    protected override IReply[] GetReplies()
    {
        return new IReply[] 
        { 
            new ReplyQ4()
        };
    }
}