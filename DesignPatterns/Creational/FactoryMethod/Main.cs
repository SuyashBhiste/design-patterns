using DesignPatterns.Creational.FactoryMethod.Factory;

namespace DesignPatterns.Creational.FactoryMethod;

public class Main
{
    public void Test()
    {
        FactoryMethod.Factory.Contract.Factory carFactory = new CarFactory();
        carFactory.GetVehicle();
        
        FactoryMethod.Factory.Contract.Factory truckFactory = new TruckFactory();
        truckFactory.GetVehicle();
    }
}