using DesignPatterns.Behavioral.Strategy.Contract;

namespace DesignPatterns.Behavioral.Strategy.Implementation;

public class Hotstar : IMovieService
{
    private readonly bool _adFree;

    public Hotstar(bool adFree)
    {
        _adFree = adFree;
    }
    
    public void Play()
    {
        Console.WriteLine("Playing movie on Hotstar with " + (_adFree ? "ad free" : "ads"));
    }
}