using DesignPatterns.Creational.AbstractFactory.Service.Contract;

namespace DesignPatterns.Creational.AbstractFactory.Service;

public class MacCheckbox : ICheckbox
{
    public void Tick()
    {
        Console.WriteLine("Mac checkbox ticked");
    }
}