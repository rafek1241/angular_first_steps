using System.Collections.Generic;
using angular.dao.Models;
using Microsoft.AspNetCore.Mvc;

namespace angular.services.Interfaces
{
    public interface IActorService
    {
        IEnumerable<Actor> GeActors();
        IEnumerable<Actor> GetActorsByMovieId(long movieId);
        Actor GetActor(long actorId);
        IActionResult SetActor(Actor actor);
        IActionResult PutActor(Actor actor);
        IActionResult RemoveActor(long actorId);
    }
}
