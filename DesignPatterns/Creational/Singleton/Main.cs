namespace DesignPatterns.Creational.Singleton;

public class Main
{
    public void Test()
    {
        Database database1 = Database.GetInstance();
        Database database2 = Database.GetInstance();
        
        Console.WriteLine(ReferenceEquals(database1, database2));
    }
}