using LibraryManagementSystemWithEF.BusinessLayer.Abstract;
using LibraryManagementSystemWithEF.BusinessLayer.Concrate;
using LibraryManagementSystemWithEF.DAL.EntityFramework;

namespace LibraryManagementSystemWithEF.DAL
{
    internal class Services
    {
        private static Services _instance;
        public static IBookService BookService = new BookManager(new EFBookDAL());
        public static IBorrowedBookService BorrowedBookService = new BorrowedBookManager(new EFBorrowedBookDAL());

        public Services()
        {
            
        }

        public Services Instance {
            get
            {
                if (_instance is null)
                {
                    _instance = new Services();
                }
                return _instance;
            }
        }
    }
}
