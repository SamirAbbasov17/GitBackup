namespace OOP.Example_1;
using Models;

public static class Program
{
    public static void Main(String[] args)
    {
        //Employee e1 = new();
        //e1.EmployeeId = 1;
        //e1.Name = "Murat";
        //e1.Detail = new()
        //{
        //    Description = "Yeni Eklendi"
        //};




        //Employee e2 = new();
        //e2.EmployeeId = 2;
        //e2.Name = "Ayşe";

        //EmployeeDetail detail = new();
        //detail.Description = "Yeni ve yeniden eklendi";
        //detail.EmployeeId = e2.EmployeeId;


        //Country c = new();
        //c.Name = "Türkiye";


        //List<City> ci = c.Cities.ToList();


        E2 e2 = new();

        var items = new Dictionary<string, object>
        {
            {"FirstName" , "Murat" },
            {"LastName", "Vuranok" },
            {"Mail", "murat@vuranok.com" }
        };

        e2.Update(items);

        Console.WriteLine(e2.FirstName);
        Console.WriteLine(e2.LastName);
        Console.WriteLine(e2.Mail);
    }
}