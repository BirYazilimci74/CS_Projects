using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class LibraryBook : Book
    {
        public int NumberOfCopy { get; set; }
        public int BorrowedCopy { get; set; }

        public LibraryBook(String title, String author, long ISBN, int numberOfCopy, int borrowedCopy)
            : base(title, author, ISBN)
        {
            this.NumberOfCopy = numberOfCopy;
            this.BorrowedCopy = borrowedCopy;
        }

        override public String ToString()
        {
            return this.Title + "=" + this.Author + "=" + this.ISBN + "=" + this.NumberOfCopy + "=" + this.BorrowedCopy;
        }
    }

}
