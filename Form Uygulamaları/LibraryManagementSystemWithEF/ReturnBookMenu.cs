using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystemWithEF.BusinessLayer.Abstract;

namespace LibraryManagementSystemWithEF
{
    public partial class ReturnBookMenu : Form
    {
        private readonly IBorrowedBookService _borrowedBooks;
        public ReturnBookMenu(IBorrowedBookService borrowedBookService)
        {
            _borrowedBooks = borrowedBookService;
            InitializeComponent();
        }

        private async void ReturnBookMenu_Load(object sender, EventArgs e)
        {
            await LoadBorrowedBooksAsync();
        }

        private async void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                await ReturnSelectedBookAsync();
                await LoadBorrowedBooksAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"An Error occured: {exception.Message}");
                throw;
            }
        }

        private async Task LoadBorrowedBooksAsync()
        {
            try
            {
                var borrowedBooksWithBookName = await Task.Run(() => _borrowedBooks.TGetBorrowedBooksWithName());
                dgvBorrowedBooks.DataSource = borrowedBooksWithBookName;
            }
            catch
            {
                MessageBox.Show("The Books Couldn't load!");
            }
        }

        private async Task ReturnSelectedBookAsync()
        {
            if (dgvBorrowedBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a book to return.", 
                    "Warning", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var selectedBookId = Convert.ToInt32(dgvBorrowedBooks.SelectedRows[0].Cells[0].Value);

            var bookToReturn = await Task.Run(() => _borrowedBooks.TGetById(selectedBookId));

            if (bookToReturn != null)
            {
                await Task.Run(() => _borrowedBooks.TReturn(bookToReturn));
                await Task.Run(() => _borrowedBooks.TDelete(bookToReturn));
            }
            else
            {
                MessageBox.Show(
                    "Book couldn't found!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async Task Search()
        {
            var searchStringBookName = tbxSearchBookName.Text.ToLower();
            var booksWithFilter = await Task.Run(() =>
            {
                if (string.IsNullOrWhiteSpace(searchStringBookName))
                {
                    return _borrowedBooks.TGetBorrowedBooksWithName();
                }

                return _borrowedBooks.TGetBorrowedBooksWithName(
                    b => b.BookName.ToLower().Contains(searchStringBookName));
            });

            dgvBorrowedBooks.DataSource = booksWithFilter;
        }

        private async void tbxSearchBookName_TextChanged(object sender, EventArgs e)
        {
            await Search();
        }
    }
}
