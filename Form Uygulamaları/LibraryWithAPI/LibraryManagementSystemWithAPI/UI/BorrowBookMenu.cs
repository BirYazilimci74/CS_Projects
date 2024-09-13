using LibraryManagementSystemWithAPI.API;

namespace LibraryManagementSystemWithAPI.UI
{
    public partial class BorrowBookMenu : Form
    {
        public BorrowBookMenu()
        {
            InitializeComponent();
        }
        private async void BorrowBookMenu_Load(object sender, EventArgs e)
        {
            BookOperations bookOperations = new BookOperations(new HttpClient());
            dgvBorrowedBooks.DataSource = await bookOperations.GetAllAsync();
        }

    }
}
