using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
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

    [HttpGet("/{id}")]
    public Movie Get(long id) => movieService.GetMovie(id);

    [HttpGet("director={directorId}")]
    public IEnumerable<Movie> GetByDirectorId(long directorId) => movieService.GetMoviesByDirectorId(directorId);

    [HttpPost]
    public HttpResponseMessage Post([FromBody]Movie value) => movieService.AddMovie(value);

    [HttpPut("/{id}")]
    public HttpResponseMessage Put([FromBody]Movie value) => movieService.UpdateMovie(value);

    [HttpDelete("/{id}")]
    public HttpResponseMessage Delete(int id) => movieService.RemoveMovie(id);
  }
}
