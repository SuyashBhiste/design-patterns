using DesignPatterns.Structural.Decorator.Base;
using DesignPatterns.Structural.Decorator.Decorator;

namespace DesignPatterns.Structural.Decorator;

public class Program
{
    public void Main()
    {
        ICoffee coffee = new SimpleCoffee();
        
        coffee = new MilkDecorator(coffee);
        coffee = new SugarDecorator(coffee);
        coffee = new CarmelDecorator(coffee);
        
        Console.WriteLine(coffee.GetDescription());
        Console.WriteLine(coffee.GetPrice());
    }
}