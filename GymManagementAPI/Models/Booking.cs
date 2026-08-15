using System.ComponentModel.DataAnnotations;

namespace GymManagementAPI.Models
{

    public enum BookingStatusType
    {
        Confirmed, 
        Cancelled, 
        Completed, 
        NoShow
    }

    public class Booking
    {
        [Key]
        public int Id { get; set; }

        public DateTime BookingDate { get; set; } = DateTime.UtcNow;

        public BookingStatusType Status { get; set; }

        [MaxLength(200)]
        public string? Notes { get; set; }


        public int MemberId { get; set; } // FK
        public Member? Member { get; set; }


        public int FitnessClassId { get; set; } // FK
        public FitnessClass? FitnessClass { get; set; }

        public PaymentTransaction? PaymentTransaction { get; set; }

    }
}
