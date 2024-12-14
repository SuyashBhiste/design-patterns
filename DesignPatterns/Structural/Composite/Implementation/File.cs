using DesignPatterns.Structural.Composite.Contract;

namespace DesignPatterns.Structural.Composite.Implementation;

public class File(string name, int size) : IFileSystem
{
    public string Name { get; } = name;

    public string Display(string indent = "")
    {
        return indent + "- File: " + Name;
    }

    public int GetSize()
    {
        return size;
    }
}