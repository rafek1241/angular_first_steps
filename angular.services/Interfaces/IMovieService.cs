using System.Collections.Generic;
using angular.dao.Models;
using Microsoft.AspNetCore.Mvc;

namespace angular.services.Interfaces
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetMovies();
        IEnumerable<Movie> GetMoviesByDirectorId(long directorId);
        Movie GetMovie(long movieId);
        IActionResult AddMovie(Movie movie);
        IActionResult UpdateMovie(long movieId, Movie movie);
        IActionResult RemoveMovie(long movieId);

    }
}
