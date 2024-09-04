using System;
using System.Windows.Forms;
using LibraryManagementSystemWithEF.BusinessLayer.Abstract;
using LibraryManagementSystemWithEF.BusinessLayer.Concrate;
using LibraryManagementSystemWithEF.DAL.EntityFramework;

namespace LibraryManagementSystemWithEF
{
    public static class Program
    {
        private static readonly IBookService BookService = new BookManager(new EFBookDAL());
        private static readonly ICategoryService CategoryService = new CategoryManager(new EFCategoryDAL());
        private static readonly IBorrowedBookService BorrowedBookService = new BorrowedBookManager(new EFBorrowedBookDAL());
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Library(BookService,BorrowedBookService,CategoryService));
        }
    }
}
