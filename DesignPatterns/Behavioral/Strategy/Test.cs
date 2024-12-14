using DesignPatterns.Behavioral.Strategy.Contract;
using DesignPatterns.Behavioral.Strategy.Implementation;

namespace DesignPatterns.Behavioral.Strategy;

public class Test
{
    public void Main()
    {
        IMovieService netflix = new Netflix();
        IMovieService hotstar = new Hotstar(false);
        IMovieService primeVideo = new PrimeVideo();

        MoviePlayer moviePlayer = new MoviePlayer(netflix);
        moviePlayer.Play();
        
        moviePlayer = new MoviePlayer(hotstar);
        moviePlayer.Play();
    }
}