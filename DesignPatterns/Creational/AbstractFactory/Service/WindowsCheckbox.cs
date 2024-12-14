using DesignPatterns.Creational.AbstractFactory.Service.Contract;

namespace DesignPatterns.Creational.AbstractFactory.Service;

public class WindowsCheckbox : ICheckbox
{
    public void Tick()
    {
        Console.WriteLine("Windows checkbox ticked");
    }
}