using DesignPatterns.Structural.Composite.Contract;

namespace DesignPatterns.Structural.Composite.Implementation;

public class Folder(string name) : IFileSystem
{
    public string Name { get; } = name;
    private readonly List<IFileSystem> _files = [];

    public void Add(IFileSystem file)
    {
        _files.Add(file);
    }
    
    public void Remove(IFileSystem file)
    {
        _files.Remove(file);
    }
    
    public string Display(string indent = "")
    {
        return indent + "+ Folder: " + Name;
    }

    public int GetSize()
    {
        return _files.Sum(file => file.GetSize());
    }
}