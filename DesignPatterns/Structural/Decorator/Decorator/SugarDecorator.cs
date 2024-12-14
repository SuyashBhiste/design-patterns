using DesignPatterns.Structural.Decorator.Base;

namespace DesignPatterns.Structural.Decorator.Decorator;

public class SugarDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
{
    public override int GetPrice()
    {
        return coffee.GetPrice() + 1;
    }

    public override string GetDescription()
    {
        return coffee.GetDescription() + ", Sugar";
    }
}