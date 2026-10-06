using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
       public string Title;
       public String Author;
       public int ISBN;

        // Paramaterised Constructor that allows us to "Construct" a new 
        // Book object
        // Consturctors save time
        public Book(String bookTitle, string bookAuthor, int bookISBN)
        { 
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN {ISBN}");
        }
    }

   
}

    