using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angular.dao.Models
{
    public class Actor
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
