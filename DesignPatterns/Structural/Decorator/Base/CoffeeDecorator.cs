namespace DesignPatterns.Structural.Decorator.Base;

public abstract class CoffeeDecorator(ICoffee coffee) : ICoffee
{
    protected readonly ICoffee Coffee = coffee;

    public virtual int GetPrice()
    {
        return Coffee.GetPrice();
    }

    public virtual string GetDescription()
    {
        return Coffee.GetDescription();
    }
}