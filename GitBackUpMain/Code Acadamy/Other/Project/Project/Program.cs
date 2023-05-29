using System;
using Project.Models;
namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new();
            library.AddBook(new Book("Deliligin Daglarinda", "Lovecraft", 200, 35.5));
            //Console.WriteLine(library.RemoveAllBooks("Deliligin Daglarinda")); 

            
            Console.WriteLine(library.GetAllBooks("Deliligin Daglarinda")[0].Name);

        }
    }
}