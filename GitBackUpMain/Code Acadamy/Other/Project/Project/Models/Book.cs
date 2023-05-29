using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    internal class Book
    {
        public Book(string name, string authorName, int pageCount, double price)
        {
            count++;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Price = price;
        }




        public int count = 0;
        private string name = "";
        public string Name { get { return name; } set { name = value; } }

        private string authorName = "";
        public string AuthorName { get { return authorName; } set { authorName = value; } }

        private int pageCount = 0;
        public int PageCount { get { return pageCount; } set { pageCount = value; } }

        private double price = 0;
        public double Price { get { return price; } set { price = value; } }

        private string mainCode = "";
        public string Code { get { foreach (string soz in name.Split(" ")) { mainCode += soz[0]; } return mainCode + "-" + count.ToString(); } }







    }
}
