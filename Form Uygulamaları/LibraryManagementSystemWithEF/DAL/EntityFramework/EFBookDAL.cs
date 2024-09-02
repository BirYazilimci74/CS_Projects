using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.VisualStyles;
using LibraryManagementSystemWithEF.DAL.Abstract;
using LibraryManagementSystemWithEF.DAL.Repository;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.DAL.EntityFramework
{
    internal class EFBookDAL : GenericRepository<Book>, IBookDAL
    {
        private readonly LibraryContext _context = new LibraryContext();
        public void Borrow(Book book)
        {
            Book bookToBorrow = _context.Books.FirstOrDefault(x => x.Id == book.Id);
            
            if (bookToBorrow != null)
            {
                bookToBorrow.Stock--;
                _context.SaveChanges();
            }
        }

        public List<BookDTO> GetBooksWithCategoryName()
        {
            // This allows us to use two table without join them,
            // more powerful then joining
            return _context.Books
                .Select(b => new BookDTO() 
                {
                    Id = b.Id,
                    Name = b.Name,
                    Author = b.Author,
                    Stock = b.Stock,
                    Category = b.Category.Name
                }).ToList();
        }
    }
}
