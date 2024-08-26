using System.Collections.Generic;
using LibraryManagementSystemWithEF.BusinessLayer.Abstract;
using LibraryManagementSystemWithEF.DAL.Abstract;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.BusinessLayer.Concrate
{
    internal class BookManager : IBookService
    {
        private IBookDAL _bookDal;
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

        public List<Book> TGetAll()
        {
            return _bookDal.GetAll();
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
    }
}
