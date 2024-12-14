namespace DesignPatterns.Creational.Singleton;

public sealed class Database
{
    private static readonly Lazy<Database> Instance = new(() => new Database());

    private Database()
    {
        Console.WriteLine("Hi, I'm private database constructor");
    }

    public static Database GetInstance() => Instance.Value;
}