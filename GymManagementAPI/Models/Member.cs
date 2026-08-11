using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public enum MembershipType {
    Monthly, Quarterly, Annual, PayAsYouGo
}

namespace GymManagementAPI.Models
{
    public class Member
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int Id { get; set; }


        [MaxLength(100)]
        [Required]
        public required string FullName { get; set; }

        [MaxLength(100)]
        [Required]
        public required string Email { get; set; }

        [MaxLength(20)]
        [Required]
        [Phone]
        public required string PhoneNumber { get; set; }

        [Required]
        public required DateTime DateOfBirth { get; set; }

        [Required]
        public required MembershipType Membership { get; set; }

        [Required]
        public required string MembershipStartDate { get; set; }


        public DateTime? MembershipEndDate { get; set; }

        [Required]
        public required bool IsActive { get; set; } //

        [Required]
        public required DateTime CreatedAt { get; set; } //

        // public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        // public ICollection<PaymentTransaction> PaymentTransactions { get; set } = new List<PaymentTransaction>();
    }
}
