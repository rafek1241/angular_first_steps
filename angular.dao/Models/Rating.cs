using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angular.dao.Models
{
    public class Rating
    {
        public float Rate { get; set; }
        public User User { get; set; }
        public Movie Movie { get; set; }
    }
}
