namespace DesignPatterns.Structural.Composite.Contract;

public interface IFileSystem
{
    string Name { get; }
    string Display(string indent = "");
    int GetSize();
}