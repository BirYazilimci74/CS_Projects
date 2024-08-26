using System;
using System.Windows.Forms;
using LibraryManagementSystemWithEF.BusinessLayer.Abstract;
using LibraryManagementSystemWithEF.DAL;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF
{
    public partial class ReturnBookMenu : Form
    {
        private IBorrowedBookService borrowedBooks = Services.BorrowedBookService;
        public ReturnBookMenu()
        {
            InitializeComponent();
        }

        private void ReturnBookMenu_Load(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnBook();
        }

        private void LoadBorrowedBooks()
        {
            dgvBorrowedBooks.DataSource = borrowedBooks.TGetBorrowedBooksWithName();
        }

        private void ReturnBook()
        {
            BorrowedBook bookToReturn =
                borrowedBooks.TGetById(Convert.ToInt32(dgvBorrowedBooks.SelectedRows[0].Cells[0].Value));

            borrowedBooks.TReturn(bookToReturn);
            borrowedBooks.TDelete(bookToReturn);

            LoadBorrowedBooks();
        }
    }
}
