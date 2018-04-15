using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using angular.dao.Models;
using angular.services.Interfaces;
using angular.services.Utils;

namespace angular.services
{
    public class MovieService : ControllerBaseWrapper, IMovieService
    {
        private readonly Context db;

        public MovieService(Context ctx)
        {
            db = ctx;
        }

        public IEnumerable<Movie> GetMovies()
        {
            return db.Movies.AsEnumerable();
        }

        public IEnumerable<Movie> GetMoviesByDirectorId(long directorId)
        {
            return db.Movies.Where(p => p.Director != null).Where(p => p.Director.DirectorId == directorId);
        }

        public Movie GetMovie(long movieId)
        {
            throw new NotImplementedException();
        }

        public IActionResult AddMovie(Movie movie)
        {
            var a = Created(movie);
            throw new NotImplementedException();
        }

        public IActionResult UpdateMovie(long movieId, Movie movie)
        {
            throw new NotImplementedException();
        }

        public IActionResult RemoveMovie(long movieId)
        {
            throw new NotImplementedException();
        }
    }
}
