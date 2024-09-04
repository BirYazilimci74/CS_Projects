using System.Collections.Generic;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.DAL.Abstract
{
    public interface IBookDAL : IGenericDAL<Book>
    {
        void Borrow(Book book);
        List<BookDTO> GetBooksWithCategoryName();
    }
}
