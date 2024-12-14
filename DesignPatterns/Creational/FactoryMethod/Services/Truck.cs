using DesignPatterns.Creational.FactoryMethod.Services.Contract;

namespace DesignPatterns.Creational.FactoryMethod.Services;

public class Truck : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Truck started...");
    }
}