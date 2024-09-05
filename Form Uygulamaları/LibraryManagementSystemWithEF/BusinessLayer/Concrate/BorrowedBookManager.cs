using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LibraryManagementSystemWithEF.BusinessLayer.Abstract;
using LibraryManagementSystemWithEF.DAL.Abstract;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.BusinessLayer.Concrate
{
    public class BorrowedBookManager : IBorrowedBookService
    {
        private readonly IBorrowedBookDAL _borrowedBookDal;

        public BorrowedBookManager(IBorrowedBookDAL borrowedBookDal)
        {
            _borrowedBookDal = borrowedBookDal;
        }
        public void TAdd(BorrowedBook t)
        {
            _borrowedBookDal.Add(t);
        }

        public void TDelete(BorrowedBook t)
        {
            _borrowedBookDal.Delete(t);
        }

        public List<BorrowedBook> TGetAll(Expression<Func<BorrowedBook, bool>> filter = null)
        {
            return _borrowedBookDal.GetAll(filter);
        }

        public List<BorrowedBookDTO> TGetBorrowedBooksWithName(Expression<Func<BorrowedBookDTO, bool>> filter = null)
        {
            return _borrowedBookDal.GetBorrowedBooksWithName(filter);
        }

        public BorrowedBook TGetById(int id)
        {
            return _borrowedBookDal.GetByID(id);
        }

        public void TReturn(BorrowedBook borrowedBook)
        {
            _borrowedBookDal.ReturnBook(borrowedBook);
        }

        public void TUpdate(BorrowedBook t)
        {
            _borrowedBookDal.Update(t);
        }
    }
}
