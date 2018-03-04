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
        HttpResponseMessage SetDirector(Director director);
        HttpResponseMessage PutDirector(Director director);
        HttpResponseMessage RemoveDirector(Director director);
    }
}
