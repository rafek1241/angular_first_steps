using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using angular.dao.Models;

namespace angular.services.Interfaces
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetMovies();
        IEnumerable<Movie> GetMoviesByDirectorId(long directorId);
        Movie GetMovie(long movieId);
        HttpResponseMessage SetMovie(Movie movie);
        HttpResponseMessage PutMovie(Movie movie);
        HttpResponseMessage RemoveMovie(Movie movie);

    }
}
