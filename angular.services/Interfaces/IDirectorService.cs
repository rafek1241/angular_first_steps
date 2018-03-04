using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using angular.dao.Models;

namespace angular.services.Interfaces
{
    public interface IDirectorService
    {
        IEnumerable<Director> GetDirectors();
        Director GetDirector(long directorId);
        Director GetDirectorByMovieId(long movieId);
        HttpResponseMessage AddDirector(Director director);
        HttpResponseMessage UpdateDirector(Director director);
        HttpResponseMessage RemoveDirector(long directorId);
    }
}
