using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class SelectedTourGuide : BaseModel
    {  
        [Key]
        public int Id { get; set; }

        // Foreign keys
        [Required]
        public string TouristId { get; set; } = null!;
        [ForeignKey(nameof(TouristId))]
        public ApplicationUser? Tourist { get; set; }

        [Required]
        public string TourguideId { get; set; } = null!;
        [ForeignKey(nameof(TourguideId))]
        public ApplicationUser? Tourguide { get; set; }

        public DateTime SelectedDate { get; set; }
        public TimeOnly SelectedTime { get; set; }
        public int Adults { get; set; } = 1;
        public bool IsConfirmed { get; set; } = false;

        public string? TourName { get; set; }
        [ForeignKey(nameof(TourName))]
        public Tour? Tour { get; set; }
    }
}
