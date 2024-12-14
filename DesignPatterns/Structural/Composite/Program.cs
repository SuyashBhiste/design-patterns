using DesignPatterns.Structural.Composite.Contract;
using DesignPatterns.Structural.Composite.Implementation;
using File = DesignPatterns.Structural.Composite.Implementation.File;

namespace DesignPatterns.Structural.Composite;

public class Program
{
    public void Main()
    {
        IFileSystem file1 = new File("File1.txt", 10);
        IFileSystem file2 = new File("File2.txt", 20);
        IFileSystem file3 = new File("File3.txt", 30);

        Folder root = new Folder("Root");
        Folder folder1 = new Folder("Folder1");
        Folder folder2 = new Folder("Folder2");
        
        folder1.Add(file1);
        folder1.Add(file2);
        folder2.Add(file3);
        
        root.Add(folder1);
        root.Add(folder2);

        Console.WriteLine(root.Name);
        Console.WriteLine(root.Display());
        Console.WriteLine(root.GetSize() + " KB");
    }
}