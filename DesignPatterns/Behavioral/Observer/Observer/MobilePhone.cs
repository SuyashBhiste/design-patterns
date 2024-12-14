namespace DesignPatterns.Behavioral.Observer.Observer;

public class MobilePhone : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine($"Current temperature displayed on mobile phone is {temperature}");
    }
}