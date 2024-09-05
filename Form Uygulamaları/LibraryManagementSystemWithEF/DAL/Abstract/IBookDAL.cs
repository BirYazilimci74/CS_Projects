using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.DAL.Abstract
{
    public interface IBookDAL : IGenericDAL<Book>
    {
        void Borrow(Book book);
        List<BookDTO> GetBooksWithCategoryName(Expression<Func<BookDTO, bool>> filter = null);
    }
}
