using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.BusinessLayer.Abstract
{
    internal interface IBookService : IGenericService<Book>
    {
        void TBorrow(Book book);
    }
}
