using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystemWithEF.BusinessLayer.Abstract;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF
{
    public partial class BorrowBookMenu : Form
    {
        private readonly IBookService _bookService;
        private readonly IBorrowedBookService _borrowedBookService;
        public BorrowBookMenu(IBookService bookService, IBorrowedBookService borrowedBookService)
        {
            _bookService = bookService;
            _borrowedBookService = borrowedBookService;
            InitializeComponent();
        }

        private async void BorrowBookMenu_Load(object sender, EventArgs e)
        {
            await LoadBooksAsync();
        }

        private async void btnBorrow_Click(object sender, EventArgs e)
        {
            await BorrowSelectedBookAsync();
            await LoadBooksAsync();
        }

        private async Task LoadBooksAsync()
        {
            try
            {
                var booksWithCategoryName = await Task.Run(() => _bookService.TGetBooksWithCategoryName());
                dgvBooks.DataSource = booksWithCategoryName;
            }
            catch
            {
                MessageBox.Show("The Books Couldn't Loaded!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task BorrowSelectedBookAsync()
        {
            int selectedBookId = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[0].Value);
            
            var bookToBorrow = _bookService.TGetById(selectedBookId);
            
            if (bookToBorrow != null)
            {
                await Task.Run(() => _bookService.TBorrow(bookToBorrow));
                
                BorrowedBook borrowedBook = new BorrowedBook()
                {
                    BorrewedTime = DateTime.Now,
                    BookID = bookToBorrow.Id,
                };
                borrowedBook.ReturnTime = borrowedBook.BorrewedTime.AddDays(15);

                await Task.Run(() => _borrowedBookService.TAdd(borrowedBook));
            }
            else
            {
                MessageBox.Show("The Book Couldn't Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
