using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.MyLocalServerAPI.Contexts
{
    public class RideShareDbContext : DbContext
    {
        public DbSet<Ride> Rides { get; set; }

        public RideShareDbContext(DbContextOptions<RideShareDbContext> options) : base(options)
        {
        }
    }
}
