using DesignPatterns.Behavioral.Strategy.Contract;

namespace DesignPatterns.Behavioral.Strategy.Implementation;

public class Netflix : IMovieService
{
    public void Play()
    {
        Console.WriteLine("Playing movie on Netflix");
    }
}