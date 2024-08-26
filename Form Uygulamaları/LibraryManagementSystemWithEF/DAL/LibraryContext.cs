using System.Data.Entity;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.DAL
{
    internal class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }
    }
}
