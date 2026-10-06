using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        // Private Fields
        private string title;
        private string author;
        private int isbn;


        // Public properties
        public string Title 
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int ISBN
        {
            get { return isbn;}
            set { isbn = value; }
        }

        //Constructor
        // Consturctors save time
        public Book(String bookTitle, string bookAuthor, int bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }
        //Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN {ISBN}");
        }
    }   
}

    