using Microsoft.EntityFrameworkCore;

namespace MyLocalServerAPI.Contexts
{
    public class ToDoDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<FlaskCard> FlaskCard { get; set; }

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
        {
        }
    }
}
