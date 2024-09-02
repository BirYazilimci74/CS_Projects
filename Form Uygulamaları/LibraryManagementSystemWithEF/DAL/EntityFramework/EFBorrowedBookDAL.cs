using System.Collections.Generic;
using System.Linq;
using LibraryManagementSystemWithEF.DAL.Abstract;
using LibraryManagementSystemWithEF.DAL.Repository;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.DAL.EntityFramework
{
    internal class EFBorrowedBookDAL : GenericRepository<BorrowedBook> , IBorrowedBookDAL
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

        public List<BorrowedBookDTO> GetBorrowedBooksWithName()
        {
            var borrowedBooks = (
                from borrowedBook in _context.BorrowedBooks        //from {name for maintable} in {maintable}
                
                join book in _context.Books                        //join {name for joining table} in {joining table}
                on borrowedBook.BookID equals book.Id              //on {maintable fk} equals {joining table pk}
                
                select new
                {
                    Id = borrowedBook.Id,
                    BorrowedTime = borrowedBook.BorrewedTime,
                    ReturnTime = borrowedBook.ReturnTime,
                    BookName = book.Name,
                }).ToList();

            List<BorrowedBookDTO> result = new List<BorrowedBookDTO>();
            
            foreach (var book in borrowedBooks)
            {
                BorrowedBookDTO borrowedBookDto = new BorrowedBookDTO
                {
                    Id = book.Id,
                    BorrewedTime = book.BorrowedTime,
                    ReturnTime = book.ReturnTime,
                    BookName = book.BookName
                };
                result.Add(borrowedBookDto);
            }

            return result;
        }
    }
}
