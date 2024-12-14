using DesignPatterns.Creational.AbstractFactory.Factory;
using DesignPatterns.Creational.AbstractFactory.Factory.Contract;
using DesignPatterns.Creational.AbstractFactory.Service.Contract;

namespace DesignPatterns.Creational.AbstractFactory;

public class Main
{
    public void Test()
    {
        IFactory factory = new MacFactory();
        IButton button = factory.GetButton();
        ICheckbox checkbox = factory.GetCheckbox();
        
        button.Click();
        checkbox.Tick();

        factory = new WindowsFactory();
        button = factory.GetButton();
        checkbox = factory.GetCheckbox();
        
        button.Click();
        checkbox.Tick();
    }
}