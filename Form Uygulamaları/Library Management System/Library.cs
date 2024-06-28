using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library_Management_System
{
    internal class Library
    {
        private string dataFilePath = "..\\..\\Datas\\LibraryDatas.txt";
        private string myLibraryFile = "..\\..\\Datas\\MyLibrary.txt";
        private static Library instance;

        public List<Book> books { get; set; }
        public LinkedList<Book> myBooks { get; set; }

        FileOperations fo = new FileOperations();

        public Library()
        {
            books = new List<Book>();
            myBooks = new LinkedList<Book>();
        }
        public static Library getInstance()
        {
            if(instance == null) 
            { 
                instance = new Library();
            }
            return instance;
        }

        public void BarrowBook(LibraryBook book)
        {
            if (book.NumberOfCopy > 0)
            {
                book.NumberOfCopy--;
                book.BorrowedCopy++;

                Book newBook = new BorrowedBook(book.Title, book.Author, book.ISBN, DateTime.Now);
                getInstance().myBooks.AddLast((BorrowedBook)newBook);
            }
        }

        public void AddBook(String title, String author, long ISBN, int numberOfCopy, int borrowedCopy)
        {
            Book newBook = new LibraryBook(title, author, ISBN, numberOfCopy, borrowedCopy);
            foreach (Book book in getInstance().books)
            {
                if ((book.Title == newBook.Title) && (book.Author == newBook.Author) && (book.ISBN == newBook.ISBN))
                {
                    MessageBox.Show("This book is already in the Library", "Warning", MessageBoxButtons.OK);
                    return;
                }
            }
            getInstance().books.Add((LibraryBook)newBook);
        }

        public void ReturnBook(LibraryBook book)
        { 
            if (book.BorrowedCopy > 0)
            {
                book.NumberOfCopy++;
                book.BorrowedCopy--;
            }
        }

        public void DisplayBooks(ListView listView)
        {
            fo.PrintFile(dataFilePath, listView);
        }

        public void SearchBook(String strToSearch, List<Book> books, ListView listView)
        {
            listView.Items.Clear();
            foreach (Book book in books)
            {
                if (book.ToString().ToLower().Contains(strToSearch.ToLower()))
                {
                    string[] proporties = book.ToString().Split('=');
                    listView.Items.Add(new ListViewItem(proporties));
                }
            }
        }
        public void SearchBook(String strToSearch, LinkedList<Book> books, ListView listView)
        {
            listView.Items.Clear();
            foreach (Book book in books)
            {
                if (book.ToString().ToLower().Contains(strToSearch.ToLower()))
                {
                    string[] proporties = book.ToString().Split('=');
                    listView.Items.Add(new ListViewItem(proporties));
                }
            }
        }

        /*
        public void SearchBorrowedBook(String strToSearch, List<Book> books, ListView listView)
        {
            listView.Items.Clear();
            foreach (Book book in books)
            {
                if (book.BorrowedBookInfo().ToLower().Contains(strToSearch.ToLower()))
                {
                    string[] proporties = book.BorrowedBookInfo().Split('=');
                    listView.Items.Add(new ListViewItem(proporties));
                }
            }
        }
        */
        public void SearchOverdue(LinkedList<Book> books, ListView listView)
        {
            listView.Items.Clear();
            foreach (BorrowedBook book in books)
            {
                if (book.ReturnTime.CompareTo(DateTime.Now) < 0)
                {
                    string[] proporties = book.ToString().Split('=');
                    listView.Items.Add(new ListViewItem(proporties));
                }
            }
        }
    }
}
