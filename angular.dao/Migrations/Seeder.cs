using System;
using System.Collections.Generic;
using System.Linq;
using angular.dao.Models;
using Microsoft.EntityFrameworkCore;

namespace angular.dao.Migrations
{
    public static class Seeder
    {
        public static void Seed(this Context ctx)
        {
            if (ctx.Database.GetPendingMigrations().Any()) return;

            if (!ctx.Users.Any())
            {
                ctx.Users.Add(new User()
                {
                    BirthDay = new DateTime(1995, 10, 13),
                    Email = "admin@admin.pl",
                    Login = "admin",
                    Name = "Administrator",
                    Password = "admin",
                    Ratings = new List<Rating>()
                });
            }

            if (!ctx.Actors.Any())
            {
                ctx.Actors.Add(new Actor()
                {
                    FirstName = "Jimmy",
                    Surname = "Carrey",
                    BirthDate = new DateTime(1995,10,1)
                });
            }
            
            if (!ctx.Movies.Any())
            {
                ctx.Movies.Add(new Movie()
                {
                    Director = null,
                    Ratings = null,
                    ActorMovies = new List<ActorMovie>(),
                    PublishDate = DateTime.Now,
                    Title = "Godfather"
                });
                ctx.Movies.Add(new Movie()
                {
                    Director = null,
                    Ratings = null,
                    ActorMovies = new List<ActorMovie>(),
                    PublishDate = DateTime.Now,
                    Title = "Godfather II"
                });
                ctx.Movies.Add(new Movie()
                {
                    Director = null,
                    Ratings = null,
                    ActorMovies = new List<ActorMovie>(),
                    PublishDate = DateTime.Now,
                    Title = "Star wars"
                });
                ctx.Movies.Add(new Movie()
                {
                    Director = null,
                    Ratings = null,
                    ActorMovies = new List<ActorMovie>(),
                    PublishDate = DateTime.Now,
                    Title = "Scarface"
                });
            }


            ctx.SaveChanges();
        }
    }
}
