using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.DAL.Abstract
{
    internal interface IBorrowedBookDAL : IGenericDAL<BorrowedBook>
    {
        void ReturnBook(BorrowedBook borrowedBook);
        List<BorrowedBookDTO> GetBorrowedBooksWithName();
    }
}
