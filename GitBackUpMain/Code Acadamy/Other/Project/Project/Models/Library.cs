using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    internal class Library
    {
        public Book[] books = new Book[0];

        public void AddBook(Book kitab)
        {
            Array.Resize(ref books, books.Length+1);
            books[books.Length - 1] = kitab;
        }

        public Book GetBook(string book)
        {

            return Array.Find(books, element => element.Name == book);
        }

        public Book[] GetAllBooks(string book)
        {
            return Array.FindAll(books, element => element.Name == book);
        }

        public int RemoveAllBooks(string book)
        {
            int oldValue = books.Length;
            books = Array.FindAll(books, element => element.Name != book);
            int newValue = books.Length;
            return oldValue - newValue;
        }
    }
}
