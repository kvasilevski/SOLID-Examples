﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.OCP
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}