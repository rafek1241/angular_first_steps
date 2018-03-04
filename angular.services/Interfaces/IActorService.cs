using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using angular.dao.Models;

namespace angular.services.Interfaces
{
    public interface IActorService
    {
        IEnumerable<Actor> GeActors();
        IEnumerable<Actor> GetActorsByMovieId(long movieId);
        Actor GetActor(long actorId);
        HttpResponseMessage SetActor(Actor actor);
        HttpResponseMessage PutActor(Actor actor);
        HttpResponseMessage RemoveActor(long actorId);
    }
}
