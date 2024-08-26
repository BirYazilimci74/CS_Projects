using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystemWithEF.BusinessLayer.Abstract;
using LibraryManagementSystemWithEF.BusinessLayer.Concrate;
using LibraryManagementSystemWithEF.DAL;
using LibraryManagementSystemWithEF.DAL.Abstract;
using LibraryManagementSystemWithEF.DAL.EntityFramework;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF
{
    public partial class Form1 : Form
    {
        private IBookService books = new BookManager(new EFBookDAL());
        private IBorrowedBookService borrowedBooks = new BorrowedBookManager(new EFBorrowedBookDAL());

        public Form1()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadBorrowedBooks();
        }

        private void LoadBooks()
        {
            dgvBooks.DataSource = books.TGetAll();
        }

        private void LoadBorrowedBooks()
        {
            dgvBorrowedBook.DataSource = borrowedBooks.TGetBorrowedBooksWithName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book bookToBorrow = books.TGetById(Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[0].Value));
            books.TBorrow(bookToBorrow);
            
            BorrowedBook borrowedBook = new BorrowedBook();
            
            borrowedBook.BorrewedTime = DateTime.Now;
            borrowedBook.ReturnTime = borrowedBook.BorrewedTime.AddDays(15);
            borrowedBook.BookID = bookToBorrow.Id;
            
            borrowedBooks.TAdd(borrowedBook);
            LoadBooks();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BorrowedBook bookToReturn =
                borrowedBooks.TGetById(Convert.ToInt32(dgvBorrowedBook.SelectedRows[0].Cells[0].Value));

            borrowedBooks.TReturn(bookToReturn);
            borrowedBooks.TDelete(bookToReturn);

            LoadBorrowedBooks();
        }
    }
}
