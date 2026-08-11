using Microsoft.EntityFrameworkCore;

namespace GymManagementAPI.Data
{
    public class GymManagementAPIDbContext : DbContext
    {
        public GymManagementAPIDbContext(DbContextOptions<GymManagementAPIDbContext> options) : base(options) { }
    }
}
