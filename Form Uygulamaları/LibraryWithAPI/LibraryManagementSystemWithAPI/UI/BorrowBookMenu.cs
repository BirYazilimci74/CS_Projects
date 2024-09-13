using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryApi.DTOs.Book;
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
