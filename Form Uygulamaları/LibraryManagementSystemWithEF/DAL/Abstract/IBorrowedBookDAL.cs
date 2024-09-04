using System.Collections.Generic;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.DAL.Abstract
{
    public interface IBorrowedBookDAL : IGenericDAL<BorrowedBook>
    {
        void ReturnBook(BorrowedBook borrowedBook);
        List<BorrowedBookDTO> GetBorrowedBooksWithName();
    }
}
