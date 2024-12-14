using DesignPatterns.Behavioral.Observer.Observer;

namespace DesignPatterns.Behavioral.Observer.WeatherStation;

public class WeatherStation : IWeatherStation
{
    private float _temperature;
    private HashSet<IObserver> _observers;

    public WeatherStation()
    {
        _observers = new HashSet<IObserver>();
    }

    public void UpdateTemperature(float temperature)
    {
        _temperature = temperature;
        Notify();
    }
    
    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update(_temperature);
        }
    }
}