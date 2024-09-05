using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.BusinessLayer.Abstract
{
    public interface IBookService : IGenericService<Book>
    {
        void TBorrow(Book book);
        List<BookDTO> TGetBooksWithCategoryName(Expression<Func<BookDTO, bool>> filter = null);
    }
}
