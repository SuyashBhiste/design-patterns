using DesignPatterns.Structural.Decorator.Base;

namespace DesignPatterns.Structural.Decorator.Decorator;

public class MilkDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
{
    public override int GetPrice()
    {
        return coffee.GetPrice() + 2;
    }

    public override string GetDescription()
    {
        return coffee.GetDescription() + ", Milk";
    }
}