
//using OOP.Class_1.Models;

namespace OOP.Class_1;
using Models;


public static class Program
{
    public static void Main(String[] args)
    {

        // isim.soyisim
        // isim
        // @code.edu.az

        // instance ( yeni bir örnek ) alma
        try
        {
            Employee employee = new Employee();
            employee.FirstName = "Murat";
            employee.LastName = "Vuranok";
            employee.Age = 18;
            //employee.Mail = "murat.vuranok@code.edu.az";

            Console.WriteLine(
                    $"""
                Adı    : {employee.FirstName}
                Soyadı : {employee.LastName}
                Yaşı   : {employee.Age} 
                Mail   : {employee.Mail}
                """);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}