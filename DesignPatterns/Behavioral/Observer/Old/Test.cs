using DesignPatterns.Behavioral.Observer.Old.Contract;
using DesignPatterns.Behavioral.Observer.Old.Implementation;

namespace DesignPatterns.Behavioral.Observer.Old;

public class Test
{
    public void Main()
    {
        IPublisher publisher = new Publisher();
        ISubscriber subscriber1 = new Subscriber();
        ISubscriber subscriber2 = new Subscriber();
        ISubscriber subscriber3 = new Subscriber();
        
        publisher.Subscribe(subscriber1);
        publisher.Subscribe(subscriber2);
        publisher.Subscribe(subscriber3);
        
        publisher.Publish("1st Video Published");
        
        publisher.Unsubscribe(subscriber2);
        publisher.Publish("2nd Video Published");
    }
}