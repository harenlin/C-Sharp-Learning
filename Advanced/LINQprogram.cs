using System;
using System.Linq;
using System.Collections.Generic;

// LINQ = Language Integrated Query, gives you the capability to query objects.

class LINQprogram {
	public class Book {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    }

	static void Main(string[] args) {
		// Define a list of books
        List<Book> books = new List<Book> {
            new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925, Price = 10.99 },
            new Book { Title = "1984", Author = "George Orwell", Year = 1949, Price = 8.99 },
            new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960, Price = 7.99 },
            new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", Year = 1951, Price = 6.99 },
            new Book { Title = "Moby-Dick", Author = "Herman Melville", Year = 1851, Price = 9.99 }
        };

		// Example LINQ queries
		// (1) Get all cheap books (under 10 dollors)
		// .OrderBy() = ascending; .OrderByDescending() = descending
		var cheapBooks = books.Where(book => book.Price < 10.00).OrderByDescending(book => book.Price);
		Console.WriteLine("Cheap Books: ");
        foreach (var book in cheapBooks) {
            Console.WriteLine($"{book.Title} by {book.Author} ({book.Year}) - ${book.Price}");
        }
		Console.WriteLine("\nCheap Book Titles: ");
		var cheapBookTitles = cheapBooks.Select(book => book.Title);
		foreach(string title in cheapBookTitles) Console.WriteLine(title);
		Console.WriteLine("===================================================================\n");

        // (2) Get all books written before the year 1950
        var oldBooks = from book in books where book.Year < 1950 select book;
        Console.WriteLine("Books Published Before 1950: ");
        foreach (var book in oldBooks) {
            Console.WriteLine($"{book.Title} by {book.Author} ({book.Year}) - ${book.Price}");
        }
		Console.WriteLine("\nOld Book Titles: ");
		var oldBookTitles = from book in oldBooks select book.Title;
		foreach(string title in oldBookTitles) Console.WriteLine(title);
		Console.WriteLine("===================================================================\n");

		// (3) Get the most expensive book
        var mostExpensiveBook = (from book in books
                                 orderby book.Price descending
                                 select book).FirstOrDefault();

        if (mostExpensiveBook != null) {
            Console.WriteLine($"The most expensive book is '{mostExpensiveBook.Title}' by {mostExpensiveBook.Author} - ${mostExpensiveBook.Price}");
        }
		Console.WriteLine("===================================================================\n");

		// (4) Get max and min price of books
		var maxPrice = books.Max(book => book.Price);
		var minPrice = books.Min(book => book.Price);
		Console.WriteLine("Max price: {0}, Min price: {1}.", maxPrice, minPrice);

		// (5) Get the count, average, and total price of books
		var booksCount = books.Count();
		var averagePrice = books.Average(book => book.Price);
		var totalPrice = books.Sum(book => book.Price);
		Console.WriteLine("Book Counts: {0}, Total Price: {1}, Average Price: {2}", booksCount, totalPrice, averagePrice);
		Console.WriteLine("===================================================================");
	}
}
