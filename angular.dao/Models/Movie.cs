using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angular.dao.Models
{
    public class Movie
    {
        public long MovieId { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<ActorMovie> ActorMovies { get; set; }
        public Director Director { get; set; }
    }
}
