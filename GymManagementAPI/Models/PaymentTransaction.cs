using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagementAPI.Models
{
    public enum PaymentMethodType
    {
        CreditCard, 
        DebitCard, 
        Cash, 
        BankTransfer, 
        PayPal
    }

    public enum StatusOfPaymentType
    {
        Pending, 
        Completed, 
        Failed, 
        Refunded
    }

    public class PaymentTransaction
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        public PaymentMethodType PaymentMethod { get; set; }

        public StatusOfPaymentType StatusOfPayment { get; set; }

        [MaxLength(50)]
        public string? ExternalTransactionId { get; set; }

        public int BookingId { get; set; }
        public Booking? Booking { get; set; }

        public int MemberId { get; set; }
        public Member? Member { get; set; }

    }
}
