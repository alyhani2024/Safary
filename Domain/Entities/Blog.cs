using Domain.Consts;
using Domain.Filters;
using Sieve.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Blog : BaseModel
    {
        public int Id { get; set; }

        [Sieve(CanFilter = true,CanSort =true)]
        [MaxLength(150, ErrorMessage = Errors.MaxLength)]
        public string Title { get; set; } = null!;
        public string CoverImage { get; set; } = null!;
        public string Description { get; set; } = null!;
		[Range(1, 30)]
		public int Duration { get; set; }
		public DateTime StartDate { get; set; }
		[DateGreaterThan("StartDate")]
		public DateTime EndDate { get; set; }
		public string Content { get; set; } = null!;
        public ICollection<TourBlog>? Tours { get; set; } = new List<TourBlog>();
        public ICollection<ApplicationUser>? TouristsAndTourGuides { get; set; } = new List<ApplicationUser>();
    }
}
