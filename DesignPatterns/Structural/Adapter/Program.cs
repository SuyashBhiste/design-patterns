using DesignPatterns.Structural.Adapter.Modern;

namespace DesignPatterns.Structural.Adapter;

public class Program
{
    public void Main()
    {
        IJsonApp app = new Convertor();
        Console.WriteLine(app.GetJsonData());
    }
}