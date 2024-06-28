using System;

namespace Library_Management_System
{
    internal class Book
    {
        public String Title { get; set; }
        public String Author { get; set; }
        public long ISBN { get; set; }

        public Book(String title, String author, long ISBN)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = ISBN;
        }

    }

}
