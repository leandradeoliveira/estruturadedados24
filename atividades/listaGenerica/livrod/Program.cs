using System;
using System.Collections.Generic;
using System.Linq; // Add this namespace for LINQ methods

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public int Pages { get; set; }
}

class  Program5
{
    
    static void Main(string[] args)
    {
        // Create a list to store book information
        List<Book> books = new List<Book>();

        // Add 5 books to the list
        books.Add(new Book
        {
            Title = "Para bilus",
            Author = "leleco",
            Publisher = "Tere Leca",
            Pages = 38,
        });

        books.Add(new Book
        {
            Title = "morro descendo ",
            Author = "Senhor subida ",
            Publisher = "subida  e descida",
            Pages = 5,
        });

        books.Add(new Book
        {
            Title = "Perna De Pau",
            Author = "Pe Esquerdo ",
            Publisher = "Joelho",
            Pages = 96,
        });

        books.Add(new Book
        {
            Title = "barby",
            Author = "Pink",
            Publisher = "boneca",
            Pages = 56,
        });

        books.Add(new Book
        {
            Title = "Pirulito Louco",
            Author = "Louco Da  Casa",
            Publisher = "The Russian Messenger",
            Pages = 29,
        });

        // Find the book with the most pages
        Book bookWithMostPages = books.OrderByDescending(b => b.Pages).First();

        // Print the information of the book with the most pages
        Console.WriteLine("Book with the most pages:");
        Console.WriteLine($"Title: {bookWithMostPages.Title}");
        Console.WriteLine($"Author: {bookWithMostPages.Author}");
        Console.WriteLine($"Publisher: {bookWithMostPages.Publisher}");
        Console.WriteLine($"Pages: {bookWithMostPages.Pages}");
    }
}
