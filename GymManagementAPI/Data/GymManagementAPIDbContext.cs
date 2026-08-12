using GymManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GymManagementAPI.Data
{
    public class GymManagementAPIDbContext : DbContext
    {
        public GymManagementAPIDbContext(DbContextOptions<GymManagementAPIDbContext> options) : base(options) { }

        public DbSet<Member> Members { get; set; }
        public DbSet<Trainer> Trainers { get; set; }

    }
}
