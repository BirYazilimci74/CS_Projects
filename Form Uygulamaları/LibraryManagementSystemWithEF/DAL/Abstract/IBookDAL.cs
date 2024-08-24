using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.DAL.Abstract
{
    internal interface IBookDAL : IGenericDAL<Book>
    {
        void Borrow(Book book);
    }
}
