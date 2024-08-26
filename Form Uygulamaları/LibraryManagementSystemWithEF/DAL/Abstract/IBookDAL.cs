using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.DAL.Abstract
{
    internal interface IBookDAL : IGenericDAL<Book>
    {
        void Borrow(Book book);
    }
}
