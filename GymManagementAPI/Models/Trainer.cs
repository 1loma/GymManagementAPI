using System.ComponentModel.DataAnnotations;

namespace GymManagementAPI.Models
{
    public class Trainer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string FullName { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public required string Email { get; set; } //

        [Required]
        [MaxLength(20)]
        [Phone]
        public required string PhoneNumber { get; set; }

        [MaxLength(100)]
        public string? Specialization { get; set; }

        [MaxLength(500)]
        public string? Bio { get; set; }

        public int ExperienceYears { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<FitnessClass> FitnessClasses { get; set; } = new List<FitnessClass>();
    
    
    }
}
