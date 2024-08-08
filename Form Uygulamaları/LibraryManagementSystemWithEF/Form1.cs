using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystemWithEF.DAL;

namespace LibraryManagementSystemWithEF
{
    public partial class Form1 : Form
    {
        private LibraryContext _context = new LibraryContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvBooks.DataSource = _context.Books.ToList();
            dgvBorrowedBook.DataSource = _context.BorrowedBooks.ToList();
        }
    }
}
