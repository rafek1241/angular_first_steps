using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angular.dao.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public virtual Director Director { get; set; }
    }
}
