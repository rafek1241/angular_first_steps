using angular.services.Interfaces;
using System;
using System.Collections.Generic;
using angular.dao.Models;
using angular.services.Utils;
using Microsoft.AspNetCore.Mvc;

namespace angular.services
{
    public class DirectorService : ControllerBaseWrapper, IDirectorService
    {
        public IEnumerable<Director> GetDirectors()
        {
            throw new NotImplementedException();
        }

        public Director GetDirector(long directorId)
        {
            throw new NotImplementedException();
        }

        public Director GetDirectorByMovieId(long movieId)
        {
            throw new NotImplementedException();
        }

        public IActionResult AddDirector(Director director)
        {
            throw new NotImplementedException();
        }

        public IActionResult UpdateDirector(long directorId, Director director)
        {
            throw new NotImplementedException();
        }

        public IActionResult RemoveDirector(long directorId)
        {
            throw new NotImplementedException();
        }
    }
}
