using DesignPatterns.Behavioral.Observer.Old.Contract;

namespace DesignPatterns.Behavioral.Observer.Old.Implementation;

public class Publisher : IPublisher
{
    private readonly List<ISubscriber> _subscribers;

    public Publisher()
    {
        _subscribers = new List<ISubscriber>();
    }
    
    public void Publish(string videoTitle)
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Notify(videoTitle);
        }
    }

    public void Subscribe(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }
}