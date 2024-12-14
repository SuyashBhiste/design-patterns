using DesignPatterns.Creational.AbstractFactory.Service.Contract;

namespace DesignPatterns.Creational.AbstractFactory.Service;

public class WindowsButton : IButton
{
    public void Click()
    {
        Console.WriteLine("Windows button clicked");
    }
}