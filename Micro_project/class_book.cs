using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    // Title, Author, Year
    public string Title {get; set;}
    public string Author {get; set;}
    public int Year {get; set;}

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;    
    }

}

class Program
{
    static void Main()
    {
        // List<Book> books_saved = new List<Book>();

        List<Book> books_saved = new List<Book>
        {
            new Book("How to train your model", "Christian", 2010),
            new Book("Highway or Lowkey", "Dr. Seus", 1988),
            new Book("The Sorcerers Apprentice", "Harry P.", 2012),
            new Book("Something to do than nothing", "Grace", 2018),
            new Book("I.T logically", "Crassius", 1950),
            new Book("Application of Deep Learning and where to find them", "Christian", 2025),
            new Book("Rise of Machine and its benefit", "Mario", 2018),
            new Book("How to sing a melody", "Sinatra", 2001),
            new Book("The Lion, The Witch and the Gilded Throne", "Harry P.", 2000),
        };

        while(true)
        {
            Console.WriteLine("Welcome to book safer, what would you like to do?");
            Console.WriteLine("1.Add new books");
            Console.WriteLine("2.Show saved books");
            Console.WriteLine("3.Exit");

            Console.Write("Choose Option: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Write("Book's title: ");
                string this_book_title = Console.ReadLine();

                Console.Write("Book's author: ");
                string this_book_author = Console.ReadLine();

                Console.Write("Book's year of creation: ");
                int this_book_year = int.Parse(Console.ReadLine());

                books_saved.Add(new Book(this_book_title, this_book_author, this_book_year));
                Console.WriteLine("Book Successfully added");
            }

            else if (input == "2")
            {
                Console.WriteLine("Books that is saved in the directory");

                if (books_saved.Count <= 0)
                {
                    Console.WriteLine("Unfortunately, no books has been saved yet");
                }
                else
                {
                    foreach (var books_in_dir in books_saved)
                    {
                        Console.WriteLine($"{books_in_dir.Title} by {books_in_dir.Author} - {books_in_dir.Year}");
                    }
                }
            }

            else if (input == "3")
            {
                break;
            }
        } 
    }

}
