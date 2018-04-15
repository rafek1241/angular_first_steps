using System.Collections.Generic;
using System.Net.Http;
using angular.dao.Models;
using angular.services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace angular.web.Controllers
{
  [Route("api/[controller]")]
  public class DirectorsController : Controller
  {
    private IDirectorService directorService;

    public DirectorsController(IDirectorService service) => directorService = service;

    [HttpGet]
    public IEnumerable<Director> Get() => directorService.GetDirectors();

    [HttpGet("{id}")]
    public Director Get(long id) => directorService.GetDirector(id);

    [HttpGet("movie={id}")]
    public Director GetByMovieId(long id) => directorService.GetDirectorByMovieId(id);

    [HttpPost]
    public IActionResult Post([FromBody]Director value) => directorService.AddDirector(value);

    [HttpPut("{id}")]
    public IActionResult Put(long id, [FromBody]Director value) => directorService.UpdateDirector(id, value);

    [HttpDelete("{id}")]
    public IActionResult Delete(long id) => directorService.RemoveDirector(id);
  }
}
