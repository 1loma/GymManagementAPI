using GymManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GymManagementAPI.Data
{
    public class GymManagementAPIDbContext : DbContext
    {
        public GymManagementAPIDbContext(DbContextOptions<GymManagementAPIDbContext> options) : base(options) { }

        public DbSet<Member> Members { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<FitnessClass> FitnessClasses { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Booking>()
                .Property(b => b.Status)
                .HasConversion<string>();

            modelBuilder.Entity<PaymentTransaction>()
                .Property(p => p.StatusOfPayment)
                .HasConversion<string>();

            modelBuilder.Entity<PaymentTransaction>()
                .Property(p => p.PaymentMethod)
                .HasConversion<string>();



            modelBuilder.Entity<Member>().HasIndex(m => m.Email).IsUnique();
            modelBuilder.Entity<Trainer>().HasIndex(t => t.Email).IsUnique();



            modelBuilder.Entity<PaymentTransaction>()
                .HasOne(p => p.Member)
                .WithMany(m => m.PaymentTransactions)
                .HasForeignKey(p => p.MemberId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Member)
                .WithMany(m => m.Bookings)
                .HasForeignKey(b => b.MemberId)
                .OnDelete(DeleteBehavior.Restrict);


        }

    }
}
