using DesignPatterns.Behavioral.Observer.Old.Contract;

namespace DesignPatterns.Behavioral.Observer.Old.Implementation;

public class Subscriber : ISubscriber
{
    public void Notify(string videoTitle)
    {
        Console.WriteLine($"New video {videoTitle} is published");
    }
}