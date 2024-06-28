using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class BorrowedBook : Book
    {
        public DateTime BorrowedTime { get; set; }
        public DateTime ReturnTime { get; set; }

        public BorrowedBook(String title, String author, long ISBN, DateTime borrowedTime)
            : base(title, author, ISBN)
        {
            this.BorrowedTime = borrowedTime;
            this.ReturnTime = borrowedTime.AddMinutes(2);
        }

        override public string ToString()
        {
            return this.Title + "=" + this.Author + "=" + this.ISBN + "=" + this.BorrowedTime + "=" + this.ReturnTime;
        }
    }
}
