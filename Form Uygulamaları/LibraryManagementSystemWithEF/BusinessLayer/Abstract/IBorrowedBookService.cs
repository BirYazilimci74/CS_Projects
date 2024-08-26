using System.Collections.Generic;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.BusinessLayer.Abstract
{
    internal interface IBorrowedBookService : IGenericService<BorrowedBook>
    {
        void TReturn(BorrowedBook borrowedBook);
        List<BorrowedBookDTO> TGetBorrowedBooksWithName();
    }
}
