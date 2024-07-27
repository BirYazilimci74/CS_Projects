using Microsoft.EntityFrameworkCore;

namespace MyLocalServerAPI.Contexts
{
    public class RideShareDbContext : DbContext
    {
        public DbSet<Ride> Rides { get; set; }

        public RideShareDbContext(DbContextOptions<RideShareDbContext> options) : base(options)
        {
        }
    }
}
