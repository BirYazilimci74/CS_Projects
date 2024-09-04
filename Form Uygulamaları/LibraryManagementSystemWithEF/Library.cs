using System;
using System.Windows.Forms;
using LibraryManagementSystemWithEF.BusinessLayer.Abstract;

namespace LibraryManagementSystemWithEF
{
    public partial class Library : Form
    {
        private readonly IBookService _bookService;
        private readonly IBorrowedBookService _borrowedBookService;
        private readonly ICategoryService _categoryService;
        public Library(IBookService bookService,IBorrowedBookService borrowedBookService, ICategoryService categoryService)
        {
            InitializeComponent();
            _bookService = bookService;
            _borrowedBookService = borrowedBookService;
            _categoryService = categoryService;
        }

        private void btnBorrowMenu_Click(object sender, EventArgs e)
        {
            BorrowBookMenu borrowBookMenu = new BorrowBookMenu();
            borrowBookMenu.Show();
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            ReturnBookMenu returnBookMenu = new ReturnBookMenu(_borrowedBookService);
            returnBookMenu.Show();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            ManageBooksMenu manageBooksMenu = new ManageBooksMenu(_bookService,_categoryService);
            manageBooksMenu.Show();
        }

        private void Library_Load(object sender, EventArgs e)
        {

        }
    }
}
