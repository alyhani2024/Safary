﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstractions
{
    public interface ITourBlogService
    {
        Task<TourBlog?> ToggleStatus(int id);
    }
}
