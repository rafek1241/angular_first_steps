using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angular.dao.Models
{
    public class ActorMovie
    {
        public long ActorMovieId { get; set; }
        public Actor Actor { get; set; }
        public Movie Movie { get; set; }
    }
}
