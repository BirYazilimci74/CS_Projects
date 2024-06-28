using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    internal class FileOperations
    {
        private string dataFilePath = "..\\..\\Datas\\LibraryDatas.txt";
        private string myLibraryFile = "..\\..\\Datas\\MyLibrary.txt";

        public void PrintToFile(string filePath, List<Book> books)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (var book in books)
                    {
                        sw.WriteLine(book);
                    }
                }
            }
        }

        public void PrintToFile(string filePath, LinkedList<Book> books)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (var book in books)
                    {
                        sw.WriteLine(book);
                    }
                }
            }
        }

        public void TakeFromFile(string filePath, List<Book> books)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    StreamReader sr = new StreamReader(fs);

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] bookInfo = bookInfo = line.Split('=');
                        long ISBN = Convert.ToInt64(bookInfo[2]);
                        int numberOfCopy = Convert.ToInt32(bookInfo[3]);
                        int borrowedCopy = Convert.ToInt32(bookInfo[4]);
                        Book newBook = new LibraryBook(bookInfo[0], bookInfo[1], ISBN, numberOfCopy, borrowedCopy);
                        books.Add(newBook);
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void TakeBorrowedFromFile(string filePath, LinkedList<Book> books)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    StreamReader sr = new StreamReader(fs);

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] bookInfo = bookInfo = line.Split('=');
                        long ISBN = Convert.ToInt64(bookInfo[2]);
                        DateTime borrowedTime = Convert.ToDateTime(bookInfo[3]);
                        DateTime returnTime = Convert.ToDateTime(bookInfo[4]);
                        Book newBook = new BorrowedBook(bookInfo[0], bookInfo[1], ISBN, borrowedTime);
                        books.AddLast(newBook);
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void PrintFile(string filePath, ListView listView)
        {
            listView.Items.Clear();
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] proporties = line.Split('=');
                    listView.Items.Add(new ListViewItem(proporties));
                }
            }
        }

        public void AddToFile(string filePath, Book book)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            {
                using(StreamWriter sr = new StreamWriter(fs)) { sr.WriteLine(book); }
            }
        }
    }

}
