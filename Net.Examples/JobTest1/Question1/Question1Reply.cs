using System.Net.Http.Headers;

namespace Net.Examples;

public class Question1Reply : QuestionReply
{
    protected override void PrintQuestion()
    {
        Console.WriteLine("Question 1: Describe ways to return more than one value with method");
    }

    protected override IReply[] GetReplies()
    {
        return new IReply[] 
        { 
            new ReplyByRef()
            , new ReplyByOut()
            , new ReplyByStruct()
            , new ReplyByClass()
            , new ReplyByTuple()
            , new ReplyByTupleVer7()
            , new ReplyByArray()
            , new ReplyByList()
            , new ReplyByDictionary()  
        };
    }
}
