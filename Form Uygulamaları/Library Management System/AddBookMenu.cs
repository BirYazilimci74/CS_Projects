using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AddBookMenu : Form
    {
        private string dataFilePath = "..\\..\\Datas\\LibraryDatas.txt";
        private string myLibraryFile = "..\\..\\Datas\\MyLibrary.txt";
        FileOperations fo = new FileOperations();
        
        public AddBookMenu()
        {
            InitializeComponent();
        }

        private void AddBookMenu_Load(object sender, EventArgs e)
        {
            fo.PrintFile(dataFilePath, listView1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearError();
            if (!CheckEmpty())
            {
                long ISBN = Convert.ToInt64(mskTxtISBN.Text);
                int numberOfCopy = Convert.ToInt32(txtNumberOfCopy.Text);
                int borrowedCopy = 0;
                
                Library.getInstance().AddBook(txtBookTitle.Text, txtBookAuthor.Text, ISBN, numberOfCopy, borrowedCopy);
                fo.PrintToFile(dataFilePath, Library.getInstance().books);
                fo.PrintFile(dataFilePath, listView1);
                ClearTextBoxes();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtSearch.Text.Equals(string.Empty))
            {
                Library.getInstance().SearchBook(txtSearch.Text, Library.getInstance().books, listView1);
            }
            else { 
                fo.PrintFile(dataFilePath, listView1); }
        }

        private bool CheckEmpty()
        {
            bool result = false;
            if (txtBookTitle.Text == string.Empty)
            { 
                txtTitleError.Text = "Title can not be empty!!";
                result = true;
            }
            if (txtBookAuthor.Text == string.Empty)
            { 
                txtAuthorError.Text = "Author can not be empty!!";
                result = true;
            }
            if (mskTxtISBN.Text == string.Empty)
            { 
                txtISBNerror.Text = "ISBM no can not be empty!!";
                result = true;
            }
            if (txtNumberOfCopy.Text == string.Empty)
            { 
                txtNOCerror.Text = "Number of Copy can not be empty!!";
                result = true;
            }
            return result;
        }
        private void ClearError()
        {
            if (txtBookTitle.Text != string.Empty)
            {
                txtTitleError.Text = "";
            }
            if (txtBookAuthor.Text != string.Empty)
            {
                txtAuthorError.Text = "";
            }
            if (mskTxtISBN.Text != string.Empty)
            {
                txtISBNerror.Text = "";
            }
            if (txtNumberOfCopy.Text != string.Empty)
            {
                txtNOCerror.Text = "";
            }
        }
        private void ClearTextBoxes()
        {
            txtBookAuthor.Text = string.Empty;
            txtBookTitle.Text = string.Empty;
            mskTxtISBN.Text = string.Empty;
            txtNumberOfCopy.Text = string.Empty;
        }

    }
}
