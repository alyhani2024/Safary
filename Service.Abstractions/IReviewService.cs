﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstractions
{
    public interface IReviewService
    {
        ReviewSummary GetReviews(int tourGuideId);
    }
}