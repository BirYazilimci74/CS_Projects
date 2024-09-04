using System;
using System.Windows.Forms;
using LibraryManagementSystemWithEF.BusinessLayer.Abstract;
using LibraryManagementSystemWithEF.DAL;

namespace LibraryManagementSystemWithEF
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var bookService = Services.BookService;
            var categoryService = Services.CategoryService;
            var borrowedBookService = Services.BorrowedBookService;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Library(bookService,borrowedBookService,categoryService));
        }
    }
}
