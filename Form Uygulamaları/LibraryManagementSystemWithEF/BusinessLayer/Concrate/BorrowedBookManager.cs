﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystemWithEF.BusinessLayer.Abstract;
using LibraryManagementSystemWithEF.DAL.Abstract;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.BusinessLayer.Concrate
{
    internal class BorrowedBookManager : IBorrowedBookService
    {
        private IBorrowedBookDAL _borrowedBookDal;

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

        public List<BorrowedBook> TGetAll()
        {
            return _borrowedBookDal.GetAll();
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
