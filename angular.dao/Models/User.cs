﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angular.dao.Models
{
    public class User
    {
        public long UserId { get; set; }
        public string Login { get; set; }
        public string Password { private get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public ICollection<Rating> Ratings { get; set; }
    }
}
