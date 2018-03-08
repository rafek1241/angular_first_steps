using System;
using System.Collections.Generic;
using System.Linq;
using angular.dao.Models;
using angular.services.Interfaces;
using Microsoft.EntityFrameworkCore;
using FluentAssertions;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Moq;
using Xunit;

namespace angular.services.tests
{
    public class MovieServiceTests : IDisposable
    {
        private IMovieService movieService;
        private IEnumerable<Movie> movies;

        public MovieServiceTests()
        {
            movies = new List<Movie>()
            {
                new Movie()
                {
                    MovieId = 1,
                    Title = "Movie A",
                },
                new Movie()
                {
                    MovieId = 2,
                    Title = "Movie B",
                },
                new Movie()
                {
                    MovieId = 3,
                    Title = "Movie C",
                }
            };
            var data = movies.AsQueryable();

            var mockSet = new Mock<DbSet<Movie>>();
            mockSet.As<IQueryable<Movie>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Movie>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Movie>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Movie>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<Context>();
            mockContext.Setup(c => c.Movies).Returns(mockSet.Object);

            movieService = new MovieService(mockContext.Object);
        }

        public void Dispose()
        {
        }

        [Fact]
        public void GetMovies_ReturnMovies()
        {
            //Act

            //Arrange
            IEnumerable<Movie> results = movieService.GetMovies();

            //Assert
            results.Should().HaveCount(3);
            results.Should().AllBeOfType<Movie>();
        }

        [Fact]
        public void GetMoviesByDirectorId_ReturnMovieWithSpecifiedDirector()
        {
            var results = movieService.GetMoviesByDirectorId(1);
        }

        public void GetMovie_ReturnMovie(long movieId)
        {
            var result = movieService.GetMovie(movieId);
        }
    }
}
