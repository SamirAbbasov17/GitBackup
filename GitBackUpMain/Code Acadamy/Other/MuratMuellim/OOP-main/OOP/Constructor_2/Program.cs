using OOP.Constructor.Models;

namespace OOP.Constructor_2;
public static class Program
{
    public static void Main(String[] args)
    {
        //Employee employee = new Employee();
        //employee.Id = 1;
        //employee.FirstName = "Murat";
        //employee.LastName = "Vuranok";
        //employee.Mail = "murat.vuranok@code.edu.az";
        //employee.Phone = "+905323520997";
        //employee.Address = "Beşiktaş / İstanbul";


        //Employee employee2 = new Employee("Murat");
        //employee2.Id = 1;
        ////employee2.FirstName = "Murat";
        //employee2.LastName = "Vuranok";
        //employee2.Mail = "murat.vuranok@code.edu.az";
        //employee2.Phone = "+905323520997";
        //employee2.Address = "Beşiktaş / İstanbul";


        //Employee employee3 = new Employee("Murat", "Vuranok");
        //employee3.Id = 1;
        ////employee2.FirstName = "Murat";
        ////employee3.LastName = "Vuranok";
        //employee3.Mail = "murat.vuranok@code.edu.az";
        //employee3.Phone = "+905323520997";
        //employee3.Address = "Beşiktaş / İstanbul";

        Employee employee4 = new Employee();
        employee4.FirstName = "Murat";
        employee4.LastName = "Vuranok";
        employee4.Phone = "+905323520997";
        employee4.Address = "Beşiktaş / İstanbul";




        //employee4.HireDate = new DateTime();
        //Console.WriteLine(employee.FirstName);
        //Console.WriteLine(employee2.FirstName);
        //Console.WriteLine(employee3.FirstName + " " + employee3.LastName);
        Console.WriteLine(employee4.HireDate);
        Console.WriteLine(employee4.Mail);


        Product p = new Product("ürün adı", 10);
 

        var product = p;  // db içerisinden aldık  _context.Products.FirstOrDefault(x => x.Id == id);
        product.Update("yeni ürün adı", "açıklaması");
        
    }
}