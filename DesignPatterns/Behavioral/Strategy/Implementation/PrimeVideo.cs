using DesignPatterns.Behavioral.Strategy.Contract;

namespace DesignPatterns.Behavioral.Strategy.Implementation;

public class PrimeVideo : IMovieService
{
    public void Play()
    {
        Console.WriteLine("Playing movie on PrimeVideo");
    }
}