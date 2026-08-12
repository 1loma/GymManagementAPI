using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GymManagementAPI.Models
{
    public enum MembershipType
    {
        Monthly, 
        Quarterly, 
        Annual, 
        PayAsYouGo
    }

    public class Member
    {
        [Key]
        [Required]
        public int Id { get; set; }


        [MaxLength(100)]
        [Required]
        public required string FullName { get; set; }

        [MaxLength(100)]
        [Required]
        [EmailAddress]
        public required string Email { get; set; } //

        [MaxLength(20)]
        [Required]
        [Phone]
        public required string PhoneNumber { get; set; }

        [Required]
        public required DateTime DateOfBirth { get; set; }

        [Required]
        public required MembershipType Membership { get; set; }

        [Required]
        public DateTime MembershipStartDate { get; set; }

        public DateTime? MembershipEndDate { get; set; }

        [Required]
        public bool IsActive { get; set; } = true;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        // public ICollection<PaymentTransaction> PaymentTransactions { get; set } = new List<PaymentTransaction>();
    }
}
