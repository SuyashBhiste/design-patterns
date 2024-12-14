namespace DesignPatterns.Behavioral.Observer.Old.Contract;

public interface IPublisher
{
    void Publish(string videoTitle);
    void Subscribe(ISubscriber subscriber);
    void Unsubscribe(ISubscriber subscriber);
}