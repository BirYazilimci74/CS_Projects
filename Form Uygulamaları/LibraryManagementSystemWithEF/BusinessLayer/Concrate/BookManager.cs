﻿using System.Collections.Generic;
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

        public List<BookDTO> TGetBooksWithCategoryName()
        {
            return _bookDal.GetBooksWithCategoryName();
        }
    }
}
