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
	public class Tour
	{
		public int Id { get; set; }

		[MaxLength(150, ErrorMessage = Errors.MaxLength)]
		public string Name { get; set; } = null!;
		public string Description { get; set; } = null!;
		public ICollection<Place>? Places { get; set; }
		public int? BlogId { get; set; }
		public Blog? Blog { get; set; }
	}
}