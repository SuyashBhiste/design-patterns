using DesignPatterns.Behavioral.Strategy.Contract;

namespace DesignPatterns.Behavioral.Strategy.Implementation;

public class MoviePlayer
{
    private readonly IMovieService _movieService;

    public MoviePlayer(IMovieService movieService)
    {
        _movieService = movieService;
    }

    public void Play()
    {
        _movieService.Play();
    }
}