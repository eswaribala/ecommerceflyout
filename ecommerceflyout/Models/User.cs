﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ecommerceflyout.Models
{
    public class User
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
        public string WebSite { get; set; }
        public Address _Address { get; set; }
        public Company _Company { get; set; }


    }
}
