using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystemWithAPI.API;

namespace LibraryManagementSystemWithAPI.UI
{
    public partial class ManageBooksMenu : Form
    {
        public ManageBooksMenu()
        {
            InitializeComponent();
        }

        private async void ManageBooksMenu_Load(object sender, EventArgs e)
        {
            BookOperations bookOperations = new BookOperations(new HttpClient());
            dgvBooks.DataSource = await bookOperations.GetAllAsync();
        }
    }
}
