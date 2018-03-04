using angular.services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using angular.dao.Models;

namespace angular.services
{
    public class DirectorService : IDirectorService
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

        public HttpResponseMessage SetDirector(Director director)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage PutDirector(Director director)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage RemoveDirector(long directorId)
        {
            throw new NotImplementedException();
        }
    }
}
