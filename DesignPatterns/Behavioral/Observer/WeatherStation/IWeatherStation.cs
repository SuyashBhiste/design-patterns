using DesignPatterns.Behavioral.Observer.Observer;

namespace DesignPatterns.Behavioral.Observer.WeatherStation;

public interface IWeatherStation
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}