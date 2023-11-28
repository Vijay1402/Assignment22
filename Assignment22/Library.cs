using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22
{
    public class Library : Book
    {
        List<Book> books = new List<Book>() 
        {
                new Book(){ BookID = 1, Title="To Kill A Mockingbird", Author="Harper Lee", Genre="Fiction", IsAvailable=true},
                new Book(){ BookID = 2, Title="A Tale of Two Cities", Author="Charles Dickens", Genre="Fiction", IsAvailable=true},
                new Book(){ BookID = 3, Title="And Then There Were None", Author="Agatha Christie", Genre="Mystery", IsAvailable=true},
                new Book(){ BookID = 4, Title="The Hobbit", Author="J.R.R. Tolkien", Genre="Fantasy", IsAvailable=false},
                new Book(){ BookID = 5, Title="The Da Vinci Code", Author="Dan Brown", Genre="Mystery", IsAvailable=true},
        };
        public void AddBook()
        {
            bool avail;
            Console.WriteLine("Enter the Title of the book");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the Author of the book");
            string author = Console.ReadLine();
            Console.WriteLine("Enter the Genre of the book");
            string genre = Console.ReadLine();
            Console.WriteLine("Confirm if book is available: Y");
            if(Console.ReadLine().ToLower() == "y") 
            {
                avail = true; 
            }
            else { avail = false; }
            books.Add(new Book() { BookID = (books.Count + 1), Title = title, Author = author, Genre = genre, IsAvailable = avail });
            Console.WriteLine("Book added successfully!");
        }

        public void ViewAllBooks()
        {
            Console.WriteLine("Details of Books");
            string avail;
            foreach (var book in books)
            {   
                if(book.IsAvailable) { avail = "Yes"; }
                else { avail = "No"; }

                Console.WriteLine("Book ID:\t" + book.BookID + "\tTitle:\t" + book.Title + "\tAuthor:\t" + book.Author + "\tGenre:\t" + book.Genre + "\tAvailability:\t"+avail+"\n");
            }
        }

        public void SearchBookByID()
        {
            string avail;
            Console.WriteLine("Enter the Book ID you would like to find");
            int ID = int.Parse(Console.ReadLine());
            bool flag = false;
            foreach (var book in books)
            {
                if (book.BookID == ID)
                {
                    flag = true;
                    if (book.IsAvailable) { avail = "Yes"; } else { avail = "No"; }
                    Console.WriteLine("Book ID:\t" + book.BookID + "\tTitle:\t" + book.Title + "\tAuthor:\t" + book.Author + "\tGenre:\t" + book.Genre + "\tAvailability:\t" + avail + "\n");
                }
            }
            if(!flag) Console.WriteLine("Invalid Book ID");

        }
        public void SearchBookByTitle()
        {
            string avail;
            bool flag = false;
            Console.WriteLine("Enter the Book Title you would like to find");
            string title = Console.ReadLine().ToLower();
            foreach (var book in books)
            {
                if (book.Title.ToLower() == title)
                {
                    flag = true;
                    if (book.IsAvailable) { avail = "Yes"; } else { avail = "No"; }
                    Console.WriteLine("Book ID:\t" + book.BookID + "\tTitle:\t" + book.Title + "\tAuthor:\t" + book.Author + "\tGenre:\t" + book.Genre + "\tAvailability:\t" + avail + "\n");
                }
            }
            if (!flag) Console.WriteLine("Invalid Book ID");
        }
    }
}
