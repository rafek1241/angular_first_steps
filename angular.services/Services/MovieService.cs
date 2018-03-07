using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using angular.dao.Models;
using angular.services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace angular.services
{
    public class MovieService : IMovieService
    {
        public readonly Context db;

        public MovieService(Context ctx)
        {
            db = ctx;
        }

        public IEnumerable<Movie> GetMovies()
        {
            return db.Movies;
        }

        public IEnumerable<Movie> GetMoviesByDirectorId(long directorId)
        {
            throw new NotImplementedException();
        }

        public Movie GetMovie(long movieId)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage AddMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage RemoveMovie(long movieId)
        {
            throw new NotImplementedException();
        }
    }
}
