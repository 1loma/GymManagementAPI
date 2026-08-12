using System.ComponentModel.DataAnnotations;

namespace GymManagementAPI.Models
{
    public class Trainer
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string FullName { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Email { get; set; } //

        [Required]
        [MaxLength(20)]
        public required string PhoneNumber { get; set; }

        [MaxLength(100)]
        public string? Specialization { get; set; }

        [MaxLength(500)]
        public string? Bio { get; set; }

        [Required]
        public int ExperienceYears { get; set; }

        [Required]
        public bool IsActive { get; set; } = true;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //public ICollection<FitnessClass> FitnessClasses { get; set; } = new List<FitnessClass>;
    
    
    }
}
