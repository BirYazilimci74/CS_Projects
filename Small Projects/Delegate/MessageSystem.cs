namespace Delegate;

public class MessageSystem
{
    public void Hello()
    {
        Console.WriteLine("Hello");
    }

    public void Alert()
    {
        Console.WriteLine("Be Carefull");
    }

    public void Hello2(string message)
    {
        Console.WriteLine(message);
    }

    public void Alert2(string alert)
    {
        Console.WriteLine(alert);
    }
}
