using System.Data.Entity;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.DAL
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
