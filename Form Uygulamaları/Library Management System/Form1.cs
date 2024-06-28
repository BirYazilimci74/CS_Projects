using System;
using System.IO;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        private string dataFilePath = "..\\..\\Datas\\LibraryDatas.txt";
        private string myLibraryFile = "..\\..\\Datas\\MyLibrary.txt";

        internal Library library;
        FileOperations fo = new FileOperations();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.library = new Library();
            fo.TakeFromFile(dataFilePath, Library.getInstance().books);
            fo.TakeBorrowedFromFile(myLibraryFile, Library.getInstance().myBooks);
        }

        private void btnBarrowBookMenu_Click(object sender, EventArgs e)
        {
            BarrowBookMenu barrowBookMenu = new BarrowBookMenu();
            barrowBookMenu.Show();
        }

        private void btnReturnBookMenu_Click(object sender, EventArgs e)
        {
            ReturnBookMenu returnBookMenu = new ReturnBookMenu();
            returnBookMenu.Show();
        }

        private void btnAddBookMenu_Click(object sender, EventArgs e)
        {
            AddBookMenu addBookMenu = new AddBookMenu();
            addBookMenu.Show();
        }
    }
}
