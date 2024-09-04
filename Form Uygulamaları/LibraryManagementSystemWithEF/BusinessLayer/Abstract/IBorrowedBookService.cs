using System.Collections.Generic;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.BusinessLayer.Abstract
{
    public interface IBorrowedBookService : IGenericService<BorrowedBook>
    {
        void TReturn(BorrowedBook borrowedBook);
        List<BorrowedBookDTO> TGetBorrowedBooksWithName();
    }
}
