using System.ComponentModel.DataAnnotations;

namespace GymManagementAPI.Models
{
    public enum DifficultyLevel
    {
        Beginner, 
        Intermediate, 
        Advanced
    }

    public class FitnessClass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [MaxLength(50)]
        [Required]
        public required string Category { get; set; }

        [Required]
        public required DifficultyLevel Difficulty { get; set; }

        [Required]
        public required int DurationMinutes { get; set; }

        [Required]
        [Range(5,30)]
        public int Capacity { get; set; }


        [MaxLength(100)]
        public string? Location { get; set; }

        [Required]
        public required DateTime ScheduleDateTime { get; set; }

        [Required]
        public bool IsCancelled { get; set; } = false;


        public int TrainerId { get; set; }
        public Trainer? Trainer { get; set; }

        //public ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    }
}
