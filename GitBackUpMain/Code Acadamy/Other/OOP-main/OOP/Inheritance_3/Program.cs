namespace OOP.Inheritance;
using Models;

public static class Program
{
    public static void Main(String[] args)
    {
        Employee employee = new();
        //Employee employee1 = new Employee();
        //var personel = new Employee();

        //var sayilar = new int[] { 1, 2, 3, 4, };
        //int[] numbers = new[] { 1, 2, 3, 4, };

        employee.Id = 1;


        Student student = new(
            firstName: "Murat",
            lastName: "Vuranok",
            schoolNumber: "123");



        Student student1 = new(
         firstName: "Murat",
         schoolNumber: "123",
         lastName: "Vuranok");
         
        student.Update("Ahmet", "", "");
    }
}