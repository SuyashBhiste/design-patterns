namespace DesignPatterns.Behavioral.Observer.Observer;

public class LedScreen : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine($"Current temperature displayed on LED screen is {temperature}");
    }
}