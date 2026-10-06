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
            set
            {
                // Check if any incoming char is a digit
                if (!value.Any(char.IsDigit))
                {
                    title = value;
                }
                else
                {
                    Console.WriteLine("Cannot enter number for title");
                }

            } 
                     
         }



        public string Author
        {
            get { return author; }
            set 
            {
                // Check if any incoming char is a digit
                if (!value.Any(char.IsDigit))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Cannot enter number for author");
                }
            }
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

    