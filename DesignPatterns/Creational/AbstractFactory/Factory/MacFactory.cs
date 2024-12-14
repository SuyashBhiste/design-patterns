using DesignPatterns.Creational.AbstractFactory.Factory.Contract;
using DesignPatterns.Creational.AbstractFactory.Service;
using DesignPatterns.Creational.AbstractFactory.Service.Contract;

namespace DesignPatterns.Creational.AbstractFactory.Factory;

public class MacFactory : IFactory
{
    public IButton GetButton()
    {
        return new MacButton();
    }

    public ICheckbox GetCheckbox()
    {
        return new MacCheckbox();
    }
}