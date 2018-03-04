using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using angular.dao.Models;
using angular.services.Interfaces;

namespace angular.services
{
    public class MovieService : IMovieService
    {
        public IEnumerable<Movie> GetMovies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetMoviesByDirectorId(long directorId)
        {
            throw new NotImplementedException();
        }

        public Movie GetMovie(long movieId)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage SetMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage PutMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage RemoveMovie(long movieId)
        {
            throw new NotImplementedException();
        }
    }
}
