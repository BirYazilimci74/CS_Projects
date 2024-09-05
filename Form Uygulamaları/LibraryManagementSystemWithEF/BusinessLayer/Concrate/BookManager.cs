using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LibraryManagementSystemWithEF.BusinessLayer.Abstract;
using LibraryManagementSystemWithEF.DAL.Abstract;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.BusinessLayer.Concrate
{
    public class BookManager : IBookService
    {
        private readonly IBookDAL _bookDal;
        public BookManager(IBookDAL bookDal)
        {
            _bookDal = bookDal;
        }
        public void TDelete(Book t)
        {
            _bookDal.Delete(t);
        }

        public Book TGetById(int id)
        {
            return _bookDal.GetByID(id);
        }

        public List<Book> TGetAll(Expression<Func<Book, bool>> filter = null)
        {
            return _bookDal.GetAll(filter);
        }

        public void TAdd(Book t)
        {
            _bookDal.Add(t);
        }

        public void TUpdate(Book t)
        {
            _bookDal.Update(t);
        }

        public void TBorrow(Book book)
        {
            _bookDal.Borrow(book);
        }

        public List<BookDTO> TGetBooksWithCategoryName(Expression<Func<BookDTO, bool>> filter = null)
        {
            return _bookDal.GetBooksWithCategoryName(filter);
        }
    }
}
