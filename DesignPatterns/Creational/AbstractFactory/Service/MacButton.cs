using DesignPatterns.Creational.AbstractFactory.Service.Contract;

namespace DesignPatterns.Creational.AbstractFactory.Service;

public class MacButton : IButton
{
    public void Click()
    {
        Console.WriteLine("Mac button clicked");
    }
}