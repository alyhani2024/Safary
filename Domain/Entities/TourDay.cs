﻿using Domain.Consts;
using Domain.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TourDay : BaseModel
    {
        public int Id { get; set; }

        [MaxLength(150, ErrorMessage = Errors.MaxLength)]
        public string Name { get; set; } = null!;
        
        public decimal Price { get; set; }
        
        public string Description { get; set; } = null!;
        
        [Range(1, 30)]
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        [DateGreaterThan("StartDate")]
        public DateTime EndDate { get; set; }
        public ICollection<Place>? Places { get; set; }
        public int? TourGuideId { get; set; }
        public TourGuide? TourGuide { get; set; }
        public ICollection<Country>? Countries{ get; set; }
        public int? TouristId { get; set; }
        public Tourist? Tourist { get; set; }


    }
}
