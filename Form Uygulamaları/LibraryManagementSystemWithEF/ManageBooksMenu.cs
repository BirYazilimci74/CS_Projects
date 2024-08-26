using System;
using System.Windows.Forms;
using LibraryManagementSystemWithEF.BusinessLayer.Abstract;
using LibraryManagementSystemWithEF.DAL;

namespace LibraryManagementSystemWithEF
{
    public partial class ManageBooksMenu : Form
    {
        private IBookService bookService = Services.BookService;
        public ManageBooksMenu()
        {
            InitializeComponent();
        }

        private void ManageBooksMenu_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            dgvBooks.DataSource = bookService.TGetAll();
        }
    }
}
