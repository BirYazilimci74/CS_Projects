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
                BorrowedBookDTO borrowedBookDto = new BorrowedBookDTO();
                borrowedBookDto.Id = book.Id;
                borrowedBookDto.BorrewedTime = book.BorrowedTime;
                borrowedBookDto.ReturnTime = book.ReturnTime;
                borrowedBookDto.BookName = book.BookName;
                result.Add(borrowedBookDto);
            }

            return result;
        }
    }
}
