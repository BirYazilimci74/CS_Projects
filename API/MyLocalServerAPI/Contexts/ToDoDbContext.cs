using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.MyLocalServerAPI.Contexts
{
    public class ToDoDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
        {
        }
    }
}
