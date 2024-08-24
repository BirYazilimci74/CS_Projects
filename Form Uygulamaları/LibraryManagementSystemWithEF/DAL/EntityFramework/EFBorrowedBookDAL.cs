using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystemWithEF.DAL.Abstract;
using LibraryManagementSystemWithEF.DAL.Repository;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.DAL.EntityFramework
{
    internal class EFBorrowedBookDAL : GenericRepository<BorrowedBook> , IBorrowedBookDAL
    {
        LibraryContext _context = new LibraryContext();
        public void ReturnBook(BorrowedBook borrowedBook)
        {
            _context.Books.FirstOrDefault(b => b.Id == borrowedBook.BookID).Stock++;
            _context.SaveChanges();
        }
    }
}
