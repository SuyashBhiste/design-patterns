using DesignPatterns.Structural.Decorator.Base;

namespace DesignPatterns.Structural.Decorator.Decorator;

public class CarmelDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
{
    public override int GetPrice()
    {
        return coffee.GetPrice() + 3;
    }

    public override string GetDescription()
    {
        return coffee.GetDescription() + ", Carmel";
    }
}