
using LibraryManagementSystemWithAPI.API;

namespace LibraryManagementSystemWithAPI.UI
{
    public partial class ReturnBookMenu : Form
    {
        public ReturnBookMenu()
        {
            InitializeComponent();
        }

        private async void ReturnBookMenu_Load(object sender, EventArgs e)
        {
            BorrowedBookOperations borrowedBookOperations = new BorrowedBookOperations(new HttpClient());
            dgvBorrowedBooks.DataSource = await borrowedBookOperations.GetAllAsync();
        }
    }
}
