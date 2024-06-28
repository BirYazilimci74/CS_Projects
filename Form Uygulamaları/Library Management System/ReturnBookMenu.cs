using System;
using System.Windows.Forms;
using System.Linq;

namespace Library_Management_System
{
    public partial class ReturnBookMenu : Form
    {
        private string dataFilePath = "..\\..\\Datas\\LibraryDatas.txt";
        private string myLibraryFile = "..\\..\\Datas\\MyLibrary.txt";

        FileOperations fo = new FileOperations();
        public ReturnBookMenu()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (listViewBorrow.SelectedItems.Count > 0)
            {
                string bookName = listViewBorrow.SelectedItems[0].SubItems[0].Text;

                foreach (LibraryBook book in Library.getInstance().books)
                {
                    if (bookName.Equals(book.Title))
                    {
                        Library.getInstance().ReturnBook(book);

                        //int index = listViewBorrow.SelectedIndices[0];
                        //listViewBorrow.SelectedItems[index].Remove();
                        //foreach (ListViewItem item in listViewBorrow.SelectedItems) {item.Remove(); }
                        fo.PrintToFile(dataFilePath, Library.getInstance().books);
                        fo.PrintFile(dataFilePath, listViewLibrary);

                        /*
                        //listViewBorrow.Items.Clear();
                        var myBook = Library.getInstance().myBooks;
                        var returnBook = from BorrowedBook in myBook
                                        where BorrowedBook.Title == bookName
                                        select BorrowedBook;
                        
                        Library.getInstance().myBooks.Remove(returnBook?.FirstOrDefault());
                        */
                        fo.PrintToFile(myLibraryFile, Library.getInstance().myBooks);
                        fo.PrintFile(myLibraryFile, listViewBorrow);
                        break;
                    }
                }
                txtReturnError.Text = "";
            }
            else { txtReturnError.Text = "Please select a book to return!!"; }

        }

        private void ReturnBookMenu_Load(object sender, EventArgs e)
        {
            fo.PrintFile(dataFilePath, listViewLibrary);
            fo.PrintFile(myLibraryFile, listViewBorrow);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtSearch.Text.Equals(string.Empty))
            {
                Library.getInstance().SearchBook(txtSearch.Text, Library.getInstance().books, listViewLibrary);
            }
            else { fo.PrintFile(dataFilePath, listViewLibrary); }
        }

        private void btnSearchMyBook_Click(object sender, EventArgs e)
        {
            if (!txtSearchBorrowed.Text.Equals(string.Empty))
            {
                Library.getInstance().SearchBook(txtSearchBorrowed.Text, Library.getInstance().myBooks, listViewBorrow);
            }
            else { fo.PrintFile(myLibraryFile, listViewBorrow); }
        }

        private void btnOverDue_Click(object sender, EventArgs e)
        {
            Library.getInstance().SearchOverdue(Library.getInstance().myBooks,listViewBorrow);
        }

    }
}
