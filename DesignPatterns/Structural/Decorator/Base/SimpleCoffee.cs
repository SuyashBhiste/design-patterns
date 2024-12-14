namespace DesignPatterns.Structural.Decorator.Base;

public class SimpleCoffee : ICoffee
{
    private const int Price = 5;
    private const string Description = "Simple Coffee";

    public int GetPrice()
    {
        return Price;
    }

    public string GetDescription()
    {
        return Description;
    }
}