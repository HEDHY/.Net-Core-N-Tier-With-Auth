﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.WebApp.Models.Users
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NIF { get; set; }
        public string Email { get; set; }
        public bool State { get; set; }
    }
}
