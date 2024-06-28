using System;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class BarrowBookMenu : Form
    {
        private string dataFilePath = "..\\..\\Datas\\LibraryDatas.txt";
        private string myLibraryFile = "..\\..\\Datas\\MyLibrary.txt";

        FileOperations fo = new FileOperations();

        public BarrowBookMenu()
        {
            InitializeComponent();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                string bookName = listView1.SelectedItems[0].SubItems[0].Text;

                foreach (LibraryBook book in Library.getInstance().books)
                {
                    if (bookName.Equals(book.Title))
                    {
                        Library.getInstance().BarrowBook(book);

                        fo.PrintToFile(dataFilePath, Library.getInstance().books);
                        fo.PrintFile(dataFilePath, listView1);
                        
                        fo.PrintToFile(myLibraryFile, Library.getInstance().myBooks);
                    }
                }
                txtBorrowError.Text = "";
            }
            else
            {
                txtBorrowError.Text = "Please select a book to borrow!!";
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtSearch.Text.Equals(string.Empty))
            {
                Library.getInstance().SearchBook(txtSearch.Text, Library.getInstance().books, listView1);
            }
            else
            {
                fo.PrintFile(dataFilePath, listView1);
            }
        }

        private void BarrowBookMenu_Load(object sender, EventArgs e)
        {
            fo.PrintFile(dataFilePath, listView1);
        }


    }
}
