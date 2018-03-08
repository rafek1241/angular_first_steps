using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace angular.dao.Models
{
    public class Context : DbContext
    {
        //For tests
        public Context() : base(new DbContextOptions<Context>()) { }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }


        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
