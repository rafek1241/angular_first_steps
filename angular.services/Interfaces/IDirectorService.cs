using System.Collections.Generic;
using angular.dao.Models;
using Microsoft.AspNetCore.Mvc;

namespace angular.services.Interfaces
{
    public interface IDirectorService
    {
        IEnumerable<Director> GetDirectors();
        Director GetDirector(long directorId);
        Director GetDirectorByMovieId(long movieId);
        IActionResult AddDirector(Director director);
        IActionResult UpdateDirector(long directorId, Director director);
        IActionResult RemoveDirector(long directorId);
    }
}
