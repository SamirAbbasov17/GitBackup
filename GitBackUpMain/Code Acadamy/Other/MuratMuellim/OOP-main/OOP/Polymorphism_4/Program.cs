namespace OOP.Polymorphism;
using Models;

public static class Program
{
    public static void Main(String[] args)
    {
        var employee = new Employee(
            "Murat",
            "",
            "Vuranok",
            "2125898745",
            "murat.vuranok@code.edu.az",
            "",
            "",
            "",
            0,
            "");


        //Console.WriteLine(employee.FullName);


        Apple apple = new();
        apple.Marka = "IPhone";
        apple.Model = "14 Pro Max";

        Samsung samsung = new();
        samsung.Marka = "Nuevo";
        samsung.Model = "Galaxy Z Flip 4";

        Nokia nokia = new();
        nokia.Marka = "nokia";
        nokia.Model = "5110";

        Console.WriteLine($"{apple.Marka}\n{apple.Model}\n{apple.Sound()}\n{apple.NotificationSond()}");
        Console.WriteLine($"{samsung.Marka}\n{samsung.Model}\n{samsung.Sound()}");
        Console.WriteLine($"{nokia.Marka}\n{nokia.Model}\n{nokia.Sound()}");

    }
}