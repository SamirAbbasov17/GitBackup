using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInLessonExeProj.Models
{
    #region 3
    //public interface IEntity
    //{

    //}

    //public class Category : IEntity
    //{
    //    public int CategoryId { get; set; }
    //    public string CategoryName { get; set; } = null!;
    //    public string? Description { get; set; }


    //    public static List<Category> Categories = new()
    //    {
    //        new Category { CategoryId = 1, CategoryName = "Beverages", Description = "Yeni Açiklama"},
    //        new Category { CategoryId = 2, CategoryName = "Condiments", Description = "Sweet and savory sauces"},
    //        new Category { CategoryId = 3, CategoryName = "Confections", Description = "Desserts, candies, and sweet breads"},
    //        new Category { CategoryId = 4, CategoryName = "Dairy Products", Description = "Cheeses"},
    //        new Category { CategoryId = 5, CategoryName = "Grains/Cereals", Description = "Breads, crackers, pasta, and cereal"},
    //        new Category { CategoryId = 6, CategoryName = "Meat/Poultry", Description = "Prepared meats"},
    //        new Category { CategoryId = 7, CategoryName = "Produce", Description = "Dried fruit and bean curd"},
    //        new Category { CategoryId = 8, CategoryName = "Seafood", Description = "Seaweed and fish"},
    //    };
    //}
    //public class Employee : IEntity
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string Mail { get; set; }
    //    public string Phone { get; set; }
    //}

    //public class Product : IEntity 
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; } = null!;
    //    public decimal Price { get; set; }
    //    public short UnitsInStock { get; set; }


    //    public static List<Product> Products = new()
    //    {
    //        new Product { Id = 1, Name = "Chai", Price = 18.00M, UnitsInStock = 39 },
    //        new Product { Id = 2, Name = "Chang", Price = 19.00M, UnitsInStock = 17 },
    //        new Product { Id = 3, Name = "Aniseed Syrup", Price = 10.00M, UnitsInStock = 13 },
    //        new Product { Id = 4, Name = "Chef Anton's Cajun Seasoning", Price = 22.00M, UnitsInStock = 53 },
    //        new Product { Id = 5, Name = "Chef Anton's Gumbo Mix", Price = 21.35M, UnitsInStock = 0 },
    //        new Product { Id = 6, Name = "Grandma's Boysenberry Spread", Price = 25.00M, UnitsInStock = 120 },
    //        new Product { Id = 7, Name = "Uncle Bob's Organic Dried Pears", Price = 30.00M, UnitsInStock = 15 },
    //        new Product { Id = 8, Name = "Northwoods Cranberry Sauce", Price = 40.00M, UnitsInStock = 6 },
    //        new Product { Id = 9, Name = "Mishi Kobe Niku", Price = 97.00M, UnitsInStock = 29 },
    //        new Product { Id = 10, Name = "Ikura", Price = 31.00M, UnitsInStock = 31 },
    //        new Product { Id = 11, Name = "Queso Cabrales", Price = 21.00M, UnitsInStock = 22 },
    //        new Product { Id = 12, Name = "Queso Manchego La Pastora", Price = 38.00M, UnitsInStock = 86 },
    //        new Product { Id = 13, Name = "Konbu", Price = 6.00M, UnitsInStock = 24 },
    //        new Product { Id = 14, Name = "Tofu", Price = 23.25M, UnitsInStock = 35 },
    //        new Product { Id = 15, Name = "Genen Shouyu", Price = 15.50M, UnitsInStock = 39 },
    //        new Product { Id = 16, Name = "Pavlova", Price = 17.45M, UnitsInStock = 29 },
    //        new Product { Id = 17, Name = "Alice Mutton", Price = 39.00M, UnitsInStock = 0 },
    //        new Product { Id = 18, Name = "Carnarvon Tigers", Price = 62.50M, UnitsInStock = 42 },
    //        new Product { Id = 19, Name = "Teatime Chocolate Biscuits", Price = 9.20M, UnitsInStock = 25 },
    //        new Product { Id = 20, Name = "Sir Rodney's Marmalade", Price = 81.00M, UnitsInStock = 40 },
    //        new Product { Id = 21, Name = "Sir Rodney's Scones", Price = 10.00M, UnitsInStock = 3 },
    //        new Product { Id = 22, Name = "Gustaf's Knäckebröd", Price = 21.00M, UnitsInStock = 104 },
    //        new Product { Id = 23, Name = "Tunnbröd", Price = 9.00M, UnitsInStock = 61 },
    //        new Product { Id = 24, Name = "Guaraná Fantástica", Price = 4.50M, UnitsInStock = 20 },
    //        new Product { Id = 25, Name = "NuNuCa Nuß-Nougat-Creme", Price = 14.00M, UnitsInStock = 76 },
    //        new Product { Id = 26, Name = "Gumbär Gummibärchen", Price = 31.23M, UnitsInStock = 15 },
    //        new Product { Id = 27, Name = "Schoggi Schokolade", Price = 43.90M, UnitsInStock = 49 },
    //        new Product { Id = 28, Name = "Rössle Sauerkraut", Price = 45.60M, UnitsInStock = 26 },
    //        new Product { Id = 29, Name = "Thüringer Rostbratwurst", Price = 123.79M, UnitsInStock = 0 },
    //        new Product { Id = 30, Name = "Nord-Ost Matjeshering", Price = 25.89M, UnitsInStock = 10 },
    //        new Product { Id = 31, Name = "Gorgonzola Telino", Price = 12.50M, UnitsInStock = 0 },
    //        new Product { Id = 32, Name = "Mascarpone Fabioli", Price = 32.00M, UnitsInStock = 9 },
    //        new Product { Id = 33, Name = "Geitost", Price = 2.50M, UnitsInStock = 112 },
    //        new Product { Id = 34, Name = "Sasquatch Ale", Price = 14.00M, UnitsInStock = 111 },
    //        new Product { Id = 35, Name = "Steeleye Stout", Price = 18.00M, UnitsInStock = 20 },
    //        new Product { Id = 36, Name = "Inlagd Sill", Price = 19.00M, UnitsInStock = 112 },
    //        new Product { Id = 37, Name = "Gravad lax", Price = 26.00M, UnitsInStock = 11 },
    //        new Product { Id = 38, Name = "Côte de Blaye", Price = 263.50M, UnitsInStock = 17 },
    //        new Product { Id = 39, Name = "Chartreuse verte", Price = 18.00M, UnitsInStock = 69 },
    //        new Product { Id = 40, Name = "Boston Crab Meat", Price = 18.40M, UnitsInStock = 123 },
    //        new Product { Id = 41, Name = "Jack's New England Clam Chowder", Price = 9.65M, UnitsInStock = 85 },
    //        new Product { Id = 42, Name = "Singaporean Hokkien Fried Mee", Price = 14.00M, UnitsInStock = 26 },
    //        new Product { Id = 43, Name = "Ipoh Coffee", Price = 46.00M, UnitsInStock = 17 },
    //        new Product { Id = 44, Name = "Gula Malacca", Price = 19.45M, UnitsInStock = 27 },
    //        new Product { Id = 45, Name = "Rogede sild", Price = 9.50M, UnitsInStock = 5 },
    //        new Product { Id = 46, Name = "Spegesild", Price = 12.00M, UnitsInStock = 95 },
    //        new Product { Id = 47, Name = "Zaanse koeken", Price = 9.50M, UnitsInStock = 36 },
    //        new Product { Id = 48, Name = "Chocolade", Price = 12.75M, UnitsInStock = 15 },
    //        new Product { Id = 49, Name = "Maxilaku", Price = 20.00M, UnitsInStock = 10 },
    //        new Product { Id = 50, Name = "Valkoinen suklaa", Price = 16.25M, UnitsInStock = 65 },
    //        new Product { Id = 51, Name = "Manjimup Dried Apples", Price = 53.00M, UnitsInStock = 20 },
    //        new Product { Id = 52, Name = "Filo Mix", Price = 7.00M, UnitsInStock = 38 },
    //        new Product { Id = 53, Name = "Perth Pasties", Price = 32.80M, UnitsInStock = 0 },
    //        new Product { Id = 54, Name = "Tourtière", Price = 7.45M, UnitsInStock = 21 },
    //        new Product { Id = 55, Name = "Pâté chinois", Price = 24.00M, UnitsInStock = 115 },
    //        new Product { Id = 56, Name = "Gnocchi di nonna Alice", Price = 38.00M, UnitsInStock = 21 },
    //        new Product { Id = 57, Name = "Ravioli Angelo", Price = 19.50M, UnitsInStock = 36 },
    //        new Product { Id = 58, Name = "Escargots de Bourgogne", Price = 13.25M, UnitsInStock = 62 },
    //        new Product { Id = 59, Name = "Raclette Courdavault", Price = 55.00M, UnitsInStock = 79 },
    //        new Product { Id = 60, Name = "Camembert Pierrot", Price = 34.00M, UnitsInStock = 19 },
    //        new Product { Id = 61, Name = "Sirop d'érable", Price = 28.50M, UnitsInStock = 113 },
    //        new Product { Id = 62, Name = "Tarte au sucre", Price = 49.30M, UnitsInStock = 17 },
    //        new Product { Id = 63, Name = "Vegie-spread", Price = 43.90M, UnitsInStock = 24 },
    //        new Product { Id = 64, Name = "Wimmers gute Semmelknödel", Price = 33.25M, UnitsInStock = 22 },
    //        new Product { Id = 65, Name = "Louisiana Fiery Hot Pepper Sauce", Price = 21.05M, UnitsInStock = 76 },
    //        new Product { Id = 66, Name = "Louisiana Hot Spiced Okra", Price = 17.00M, UnitsInStock = 4 },
    //        new Product { Id = 67, Name = "Laughing Lumberjack Lager", Price = 14.00M, UnitsInStock = 52 },
    //        new Product { Id = 68, Name = "Scottish Longbreads", Price = 12.50M, UnitsInStock = 6 },
    //        new Product { Id = 69, Name = "Gudbrandsdalsost", Price = 36.00M, UnitsInStock = 26 },
    //        new Product { Id = 70, Name = "Outback Lager", Price = 15.00M, UnitsInStock = 15 },
    //        new Product { Id = 71, Name = "Flotemysost", Price = 21.50M, UnitsInStock = 26 },
    //        new Product { Id = 72, Name = "Mozzarella di Giovanni", Price = 34.80M, UnitsInStock = 14 },
    //        new Product { Id = 73, Name = "Röd Kaviar", Price = 15.00M, UnitsInStock = 101 },
    //        new Product { Id = 74, Name = "Longlife Tofu", Price = 10.00M, UnitsInStock = 4 },
    //        new Product { Id = 75, Name = "Rhönbräu Klosterbier", Price = 7.75M, UnitsInStock = 125 },
    //        new Product { Id = 76, Name = "Lakkalikööri", Price = 18.00M, UnitsInStock = 57 },
    //        new Product { Id = 77, Name = "Original Frankfurter grüne Soße", Price = 13.00M, UnitsInStock = 32 }
    //    };
    //} 
    #endregion



}
