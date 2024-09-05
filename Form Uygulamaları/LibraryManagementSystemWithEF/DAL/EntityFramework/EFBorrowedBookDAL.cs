using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LibraryManagementSystemWithEF.DAL.Abstract;
using LibraryManagementSystemWithEF.DAL.Repository;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.DAL.EntityFramework
{
    public class EFBorrowedBookDAL : GenericRepository<BorrowedBook> , IBorrowedBookDAL
    {
        private readonly LibraryContext _context = new LibraryContext();
        public void ReturnBook(BorrowedBook borrowedBook)
        {
            var book = _context.Books.FirstOrDefault(b => b.Id == borrowedBook.BookID);
            
            if (book != null)
            {
                book.Stock++;
                _context.SaveChanges();
            }
        }

        public List<BorrowedBookDTO> GetBorrowedBooksWithName(Expression<Func<BorrowedBookDTO, bool>> filter = null)
        {
            var borrowedBooks = (
                from borrowedBook in _context.BorrowedBooks        //from {name for maintable} in {maintable}
                
                join book in _context.Books                        //join {name for joining table} in {joining table}
                on borrowedBook.BookID equals book.Id              //on {maintable fk} equals {joining table pk}
                
                select new BorrowedBookDTO
                {
                    Id = borrowedBook.Id,
                    BorrewedTime = borrowedBook.BorrewedTime,
                    ReturnTime = borrowedBook.ReturnTime,
                    BookName = book.Name,
                });

            return filter != null ? borrowedBooks.Where(filter).ToList() : borrowedBooks.ToList();
        }
    }
}
