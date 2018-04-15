using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using angular.dao.Models;
using angular.services.Interfaces;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace angular.services.tests
{
    [TestFixture]
    public class MovieServiceTests
    {
        private IMovieService movieService;
        private Mock<Context> db;
        private List<Movie> movies;

        #region Setup tests

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var directors = new List<Director>()
            {
                new Director()
                {
                    DirectorId = 1,
                    Name = "Jack",
                    Surname = "Sparrow",
                    Movies = new List<Movie>()
                },
                new Director()
                {
                    DirectorId = 2,
                    Name = "OneMovieDirector",
                    Surname = "Test",
                    Movies = new List<Movie>()
                },
                new Director()
                {
                    DirectorId = 3,
                    Name = "NoMovieDirector",
                    Surname = "Test",
                    Movies = new List<Movie>()
                }
            };

            movies = new List<Movie>()
            {
                new Movie()
                {
                    MovieId = 1,
                    Title = "Movie A",
                    Director = directors[0]
                },
                new Movie()
                {
                    MovieId = 2,
                    Title = "Movie B",
                    Director = directors[0]
                },
                new Movie()
                {
                    MovieId = 3,
                    Title = "Movie C",
                    Director = directors[1]
                }
            };

            var data = movies.AsQueryable();

            var mockSet = new Mock<DbSet<Movie>>();
            mockSet.As<IQueryable<Movie>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Movie>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Movie>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Movie>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            db = new Mock<Context>();

            db.Setup(c => c.Movies).Returns(mockSet.Object);

            movieService = new MovieService(db.Object);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // TODO: Add code here that is run after
            //  all tests in the assembly have been run
        }

        #endregion

        [Test]
        public void GetMovies_ReturnsMovies()
        {
            //Act
            var result = movieService.GetMovies();
            //Assert
            result.Should().HaveCount(3);
            result.Should().AllBeOfType<Movie>();

        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void GetMovie_MovieExists_ReturnMovie(long movieId)
        {
            //Act
            var result = movieService.GetMovie(movieId);
            //Assert
            result.Should().BeOfType<Movie>();
            result.Should().NotBeNull();
        }

        [TestCase(4)]
        public void GetMovie_MovieNotExists_ReturnNull(long movieId)
        {
            //Act
            var result = movieService.GetMovie(movieId);
            //Assert
            result.Should().BeOfType<Movie>();
            result.Should().BeNull();
        }

        [TestCase(1)]
        public void GetMoviesByDirectoryId_MoviesForDirectorExists_ReturnDirectorMovies(long directorId)
        {
            //Act
            var result = movieService.GetMoviesByDirectorId(directorId);
            //Assert
            result.Should().HaveCountGreaterThan(1);
            result.Should().AllBeOfType<Movie>();
        }

        [TestCase(2)]
        public void GetMoviesByDirectoryId_MovieForDirectorExists_ReturnDirectorMovie(long directorId)
        {
            //Act
            var result = movieService.GetMoviesByDirectorId(directorId);
            //Assert
            result.Should().HaveCount(1);
            result.Should().AllBeOfType<Movie>();
        }

        [TestCase(3)]
        public void GetMoviesByDirectoryId_MovieForDirectorNotExists_ReturnNull(long directorId)
        {
            //Act
            var result = movieService.GetMoviesByDirectorId(directorId);
            //Assert
            result.Should().HaveCount(0);
            result.Should().AllBeOfType<Movie>();
            result.Should().BeNullOrEmpty();
        }

        [Test]
        public void AddMovie_WithFilledMovie_ReturnAddedMovie()
        {
            var movie = new Movie()
            {
                Title = "MyMovie"
            };

            var result = movieService.AddMovie(movie);

            result.Should().BeOfType<ObjectResult>().Which.StatusCode.Should().Be(201);
            result.Should().BeOfType<ObjectResult>().Which.Value.Should().BeOfType<Movie>().Which.MovieId.Should().BePositive();
        }

        [Test]
        public void AddMovie_ValidationError_BadRequest()
        {
            var movie = new Movie();

            var result = movieService.AddMovie(movie);

            result.Should().BeOfType<BadRequestResult>();
        }

        [Test]
        public void UpdateMovie_WithFilledMovie_Ok()
        {
            var a = new Movie()
            {
                Title = "Overwrite movie"
            };

            var result = movieService.UpdateMovie(1, a);

            result.Should().BeOfType<OkObjectResult>().Which.StatusCode.Value.Should().Be(200);
            result.Should().BeOfType<OkObjectResult>().Which.Value.Should().BeOfType<Movie>().Which.Title.Equals(a.Title);
        }

        [Test]
        public void UpdateMovie_ValidationError_BadRequest()
        {

        }

        [Test]
        public void RemoveMovie_ExistingMovie_Ok()
        {

        }

        [Test]
        public void RemoveMovie_NotExistingMovie_NotFound()
        {

        }
    }
}