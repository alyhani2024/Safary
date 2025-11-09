using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Sieve.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Domain.Entities
{
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(UserName), IsUnique = true)]
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(150)]
        [Sieve(CanFilter = true, CanSort = true)]
        public string FirstName { get; set; }

        [MaxLength(150)]
        [Sieve(CanFilter = true, CanSort = true)]
        public string LastName { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public string FullName { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public string Address { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public bool IsDeleted { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public bool AdminAccepted { get; set; } = false;

        public string? CvUrl { get; set; }

        public string? ImageUrl { get; set; }

        // TourGuide fields
        public string? Description { get; set; }

        [Sieve(CanSort = true)]
        public double Rate { get; set; }

        [Sieve(CanSort = true)]
        public decimal HourPrice { get; set; }

        public int Age { get; set; }

        public string? Bio { get; set; }

        public List<string>? LanguageSpoken { get; set; } = new List<string>();

        public int? BlogId { get; set; }
        public Blog? Blog { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public bool HasCar { get; set; } = false;

        [Sieve(CanSort = true)]
        public int? ReviewsNumber { get; set; }

        // Reviews written by the tourist
        public ICollection<TourReview>? TourReviews { get; set; }

        // Reviews written by the tourist for tour guides
        public ICollection<TourGuideReview>? TourGuideTouristReviews { get; set; }

        // Reviews received by the tour guide
        public ICollection<TourGuideReview>? TourGuideReviews { get; set; }

        // Selected Tour Guides (as a tourist and as a guide)
        public ICollection<SelectedTourGuide>? Tourists { get; set; }
        public ICollection<SelectedTourGuide>? Tourguides { get; set; }
    }
}
