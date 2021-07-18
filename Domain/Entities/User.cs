﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email  { get; set; }

        public User () { }
        public User(int id, string firstName, string lastName, string email)
        {
            (Id, FirstName, LastName, Email) = (id, firstName, lastName, email);
        }
    }
}
