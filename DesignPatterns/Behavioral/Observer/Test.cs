using DesignPatterns.Behavioral.Observer.Observer;
using DesignPatterns.Behavioral.Observer.WeatherStation;

namespace DesignPatterns.Behavioral.Observer;

public class Test
{
    public void Main()
    {
        WeatherStation.WeatherStation weatherStation = new WeatherStation.WeatherStation();
        IObserver mobile = new MobilePhone();
        IObserver screen = new LedScreen();
        
        weatherStation.Attach(mobile);
        weatherStation.Attach(screen);
        
        weatherStation.UpdateTemperature(10.0f);
        
        weatherStation.Detach(mobile);
        weatherStation.UpdateTemperature(5.0f);
    }
}