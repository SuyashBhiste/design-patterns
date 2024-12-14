using DesignPatterns.Creational.FactoryMethod.Services.Contract;

namespace DesignPatterns.Creational.FactoryMethod.Services;

public class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car started...");
    }
}