using System.ComponentModel.DataAnnotations;

namespace GymManagementAPI.Models
{

    public enum StatusType
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

        public StatusType Status { get; set; }

        [MaxLength(200)]
        public string? Notes { get; set; }


        public int MemberId { get; set; } // FK
        public Member? Member { get; set; }


        public int FitnessClassId { get; set; } // FK
        public FitnessClass? FitnessClass { get; set; }

    }
}
