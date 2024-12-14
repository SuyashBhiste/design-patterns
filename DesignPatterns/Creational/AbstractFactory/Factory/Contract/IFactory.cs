using DesignPatterns.Creational.AbstractFactory.Service.Contract;

namespace DesignPatterns.Creational.AbstractFactory.Factory.Contract;

public interface IFactory
{
    IButton GetButton();
    
    ICheckbox GetCheckbox();
}