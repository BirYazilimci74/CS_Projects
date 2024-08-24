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
    internal class EFBookDAL : GenericRepository<Book>, IBookDAL
    {
        LibraryContext _context = new LibraryContext();
        public void Borrow(Book book)
        {
            Book bookToBorrow = _context.Books.FirstOrDefault(x => x.Id == book.Id);
            bookToBorrow.Stock--;
            _context.SaveChanges();
        }
    }
}
