﻿using Domain.Entities;
using Domain.Repositories;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstractions
{
	public interface ITourRepository : IBaseRepository<Tour>
	{
		 Task<bool> SelectTourAsync(string userId, string tourName);
		 Task<bool> ConfirmedTourAsync(string userId);
		Task<IEnumerable<Tour>> GetAllToursWithImages();
        Task<Tour> GetToursImagesWithName(string name);
		Task<bool> Update(string name, TourHourPostDTO dto);

    }
}
