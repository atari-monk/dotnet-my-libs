namespace Net.Examples;

public class ReplyQ3 : IReply
{
    public void GetReply()
    {
        double sum = 0;
        while (sum != 1)
        {
            sum += .1;
            Console.WriteLine("Sum: {0}", sum);
            if(sum > 1.2) break;
        }
        Console.WriteLine("While has no exit condition due to double not beeing precise.");
    }
}
