using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angular.dao.Models
{
    public class Director
    {
        public long DirectorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Movie> Movies { get; set; }

    }
}
