using DesignPatterns.Creational.FactoryMethod.Services.Contract;

namespace DesignPatterns.Creational.FactoryMethod.Factory.Contract;

public abstract class Factory
{
     public abstract IVehicle GetVehicle();
}