using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.BusinessLayer.Abstract
{
    internal interface IBorrowedBookService : IGenericService<BorrowedBook>
    {
        void TReturn(BorrowedBook borrowedBook);
    }
}
