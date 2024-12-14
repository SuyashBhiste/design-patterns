using DesignPatterns.Creational.FactoryMethod.Services;
using DesignPatterns.Creational.FactoryMethod.Services.Contract;

namespace DesignPatterns.Creational.FactoryMethod.Factory;

public class TruckFactory : FactoryMethod.Factory.Contract.Factory
{
    public override IVehicle GetVehicle()
    {
        return new Truck();
    }
}