using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LibraryManagementSystemWithEF.DAL.Abstract;
using LibraryManagementSystemWithEF.DAL.Repository;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.DAL.EntityFramework
{
    public class EFBookDAL : GenericRepository<Book>, IBookDAL
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

        public List<BookDTO> GetBooksWithCategoryName(Expression<Func<BookDTO, bool>> filter = null)
        {
            // This allows us to use two table without join them,
            // more powerful then joining
            var query = _context.Books
                .Select(b => new BookDTO() 
                {
                    Id = b.Id,
                    Name = b.Name,
                    Author = b.Author,
                    Stock = b.Stock,
                    Category = b.Category.Name
                });

            return filter != null ? query.Where(filter).ToList() : query.ToList();
        }
    }
}
