using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.BusinessLayer.Abstract
{
    public interface IBorrowedBookService : IGenericService<BorrowedBook>
    {
        void TReturn(BorrowedBook borrowedBook);
        List<BorrowedBookDTO> TGetBorrowedBooksWithName(Expression<Func<BorrowedBookDTO, bool>> filter = null);
    }
}
