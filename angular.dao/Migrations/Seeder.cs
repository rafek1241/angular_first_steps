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

            ctx.SaveChanges();
        }
    }
}
