using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.DAL.Abstract
{
    public interface IBorrowedBookDAL : IGenericDAL<BorrowedBook>
    {
        void ReturnBook(BorrowedBook borrowedBook);
        List<BorrowedBookDTO> GetBorrowedBooksWithName(Expression<Func<BorrowedBookDTO, bool>> filter = null);
    }
}
