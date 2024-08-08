using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.DAL
{
    internal class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }
    }
}
