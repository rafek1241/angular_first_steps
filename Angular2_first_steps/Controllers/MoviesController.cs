using System.Collections.Generic;
using System.Net.Http;
using angular.dao.Models;
using angular.services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace angular.web.Controllers
{
  [Route("api/[controller]")]
  public class MoviesController : Controller
  {
    private IMovieService movieService;

    public MoviesController(IMovieService movieService) => this.movieService = movieService;

    [HttpGet]
    public IEnumerable<Movie> Get() => movieService.GetMovies();

    [HttpGet("{id}")]
    public Movie Get(long id) => movieService.GetMovie(id);

    //TODO: fix url
    [HttpGet("director={director}")]
    public IEnumerable<Movie> GetByDirectorId(long director) => movieService.GetMoviesByDirectorId(director);

    [HttpPost]
    public IActionResult Post([FromBody]Movie value) => movieService.AddMovie(value);

    [HttpPut("/movies/{id}")]
    public IActionResult Put(int id, [FromBody]Movie value) => movieService.UpdateMovie(id,value);

    [HttpDelete("/movies/{id}")]
    public IActionResult Delete(int id) => movieService.RemoveMovie(id);
  }
}
