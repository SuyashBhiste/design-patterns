using DesignPatterns.Creational.AbstractFactory.Factory.Contract;
using DesignPatterns.Creational.AbstractFactory.Service;
using DesignPatterns.Creational.AbstractFactory.Service.Contract;

namespace DesignPatterns.Creational.AbstractFactory.Factory;

public class WindowsFactory : IFactory
{
    public IButton GetButton()
    {
        return new WindowsButton();
    }

    public ICheckbox GetCheckbox()
    {
        return new WindowsCheckbox();
    }
}