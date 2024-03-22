﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Country: BaseModel
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; } = null!;
    }
}
