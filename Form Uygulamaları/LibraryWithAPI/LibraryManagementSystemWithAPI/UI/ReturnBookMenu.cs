
using LibraryManagementSystemWithAPI.API;
using LibraryManagementSystemWithAPI.Mappers;

namespace LibraryManagementSystemWithAPI.UI
{
    public partial class ReturnBookMenu : Form
    {
        private readonly BorrowedBookOperations _borrowedBookOperations;
        private readonly BookOperations _bookOperations;
        public ReturnBookMenu(BorrowedBookOperations borrowedBookOperations, BookOperations bookOperations)
        {
            InitializeComponent();
            _borrowedBookOperations = borrowedBookOperations;
            _bookOperations = bookOperations;
        }

        private async void ReturnBookMenu_Load(object sender, EventArgs e)
        {
            await LoadBorrowedBooksAsync();
        }

        private async Task LoadBorrowedBooksAsync()
        {
            // Taking borrewedbooks from database
            var borrowedBooks = await _borrowedBookOperations.GetAllAsync();
            var borrowedBookDto = borrowedBooks.Select(bb => bb.ToBorrowedBookDTO()).ToList();

            // Taking books from database
            var books = await _bookOperations.GetAllAsync();
            // Mapping id -> name for books
            var bookDictionary = books.ToDictionary(b => b.Id, b => b.Name);
            
            var dgvSource = borrowedBookDto.Select(bd => new
            {
                Id = bd.Id,
                //taking book that mapped with bookId
                Book = bookDictionary.ContainsKey(bd.BookID) ? bookDictionary[bd.BookID] : null,
                bd.BorrewedTime,
                bd.ReturnTime
            }).ToList();
            
            dgvBorrowedBooks.DataSource = dgvSource;

            if (dgvBorrowedBooks.Columns.Contains("Id"))
            {
                dgvBorrowedBooks.Columns["Id"].Visible = false;
            }
        }

        private int DetermineSelectedBorrowedBookId()
        {
            int selectedRow = dgvBorrowedBooks.SelectedRows[0].Index;
            int selectedBorrowedBookId = Convert.ToInt32(dgvBorrowedBooks.Rows[selectedRow].Cells[0].Value);
            return selectedBorrowedBookId;
        }

        private async void btnReturn_Click(object sender, EventArgs e)
        {
            await ReturnSelectedBook();
            await LoadBorrowedBooksAsync();
        }

        private async Task ReturnSelectedBook()
        {
            int selectedBorrowedBookId = DetermineSelectedBorrowedBookId();
            await _borrowedBookOperations.DeleteBorrowedBookByIdAsync(selectedBorrowedBookId);
        }
    }
}
