using System;
using System.Collections.Generic;

namespace Library_Catalog_System
{
    class Book
    {
        public string Title;
        public string Author;
        public string Publication_Year;
        public Book(string title,string author,string publication_year)
        {
            Title = title;
            Author = author;
            Publication_Year = publication_year;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool success;
            bool finish=true;
            int Choice;
            Book LOTR = new Book("Lord Of The Rings", "JRR Tolkien", "1954");
            Dictionary < string, Book> allbooks = new Dictionary<string, Book>();

            allbooks.Add("Lord Of The Ringsf", LOTR);
            while (finish)
            {
                Menu();
                success = int.TryParse(Console.ReadLine(), out Choice);
                
                if (success)
                {
                    switch (Choice)
                    {
                        case 1:
                            {   
                                //adding a new book
                                Book newbook = AddBook();
                                if (newbook != null)
                                {
                                    allbooks.Add(newbook.Title, newbook);
                                }
                                continue;
                            }
                        case 2:
                            {
                                //searching for a book
                                Book BookFound;
                                string bookName;
                                Console.WriteLine("Enter the title of the book:");
                                bookName = Console.ReadLine();
                                BookFound = FindBook(allbooks, bookName);
                                if (BookFound != null)
                                {
                                    Console.WriteLine("Book Found");
                                    Console.WriteLine("The title of the book: " + BookFound.Title);
                                    Console.WriteLine("The author of the book: " + BookFound.Author);
                                    Console.WriteLine("The publication year of the book: " + BookFound.Publication_Year);
                                }
                                continue;
                            }
                        case 3:
                            {
                                //displaying all books
                                foreach (Book book in allbooks.Values)
                                {

                                    Console.WriteLine();
                                    Console.Write(" The title of the book: " + book.Title);
                                    Console.Write(" The author of the book: " + book.Author);
                                    Console.Write(" the publication year of the book: " + book.Publication_Year);
                                    Console.WriteLine();
                                }
                                continue;

                            }
                        case 4:
                            {
                                //EXİT
                                Console.WriteLine("Goodbye");
                                finish = false;
                                break;
                            }

                    }
                } else
                {
                    //wrong input error
                    Console.WriteLine("Choose a proper number");
                    continue;
                }
            }
        }
        public static void Menu()
        {
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. Search for a Book");
            Console.WriteLine("3. Display all books");
            Console.WriteLine("4. Exit");
        }
        public static Book AddBook()
        {
            Book newbook = new Book("default", "default", "default");
               
            Console.WriteLine("Write the title of the book: ");
            newbook.Title = Console.ReadLine();

            Console.WriteLine("Write the author of the book: ");
            newbook.Author = Console.ReadLine();

            Console.WriteLine("Write the publication year of the book: ");
            newbook.Publication_Year = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(newbook.Publication_Year)|| int.TryParse(newbook.Publication_Year, out int parsedYear) || string.IsNullOrWhiteSpace(newbook.Author) || string.IsNullOrWhiteSpace(newbook.Title)) 
            {
                Console.WriteLine("wrong input");
                newbook=null;
            }      
            return newbook;

        }
        public static Book FindBook(Dictionary<string,Book> booklist,string bookName)
        {
            string Searching;
            Searching = bookName;
            if (booklist.TryGetValue(bookName ,out Book book))
            {
                return book;
            }
            Console.WriteLine("Book couldn't found");
            return null;
        }
    }
}
