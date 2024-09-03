using System;
using System.Windows.Forms;
using LibraryManagementSystemWithEF.BusinessLayer.Abstract;
using LibraryManagementSystemWithEF.BusinessLayer.Concrate;
using LibraryManagementSystemWithEF.DAL;
using LibraryManagementSystemWithEF.DAL.EntityFramework;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF
{
    public partial class BorrowBookMenu : Form
    {
        private IBookService _bookService = Services.BookService;
        private IBorrowedBookService _borrowedBookService = Services.BorrowedBookService;
        public BorrowBookMenu()
        {
            InitializeComponent();
        }

        private void BorrowBookMenu_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            BorrowBook();
        }

        private void LoadBooks()
        {
            dgvBooks.DataSource = _bookService.TGetBooksWithCategoryName();
        }

        private void BorrowBook()
        {
            Book bookToBorrow = _bookService.TGetById(Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[0].Value));
            _bookService.TBorrow(bookToBorrow);

            BorrowedBook borrowedBook = new BorrowedBook();

            borrowedBook.BorrewedTime = DateTime.Now;
            borrowedBook.ReturnTime = borrowedBook.BorrewedTime.AddDays(15);
            borrowedBook.BookID = bookToBorrow.Id;

            _borrowedBookService.TAdd(borrowedBook);

            LoadBooks();
        }
    }
}
