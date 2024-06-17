﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public class TouristDto
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public string? ImageUrl { get; set; }
        public int Age { get; set; }
        public string? Bio { get; set; }
    }
}
