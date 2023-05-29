namespace OOP.ReferanceAndValueTypes;

public class Ogrenci
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public struct Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}



public static class Program
{


    public static void Main(String[] args)
    {

        Ogrenci ogr1 = new();
        ogr1.FirstName = "Murat";
        ogr1.LastName = "Vuranok";


        Ogrenci ogr2 = ogr1;
        ogr2.FirstName = "Ahmet";

        //Console.WriteLine(
        //    "Öğrencinin Adı : " + ogr1.FirstName
        //    );


        Student st1 = new();
        st1.FirstName = "Mehmet";
        st1.LastName = "Vuranok";

        Student st2 = st1;
        st2.FirstName = "Mustafa";

        Console.WriteLine(
            "Öğrencinin Adı : " + st1.FirstName
            );


        int a = 5;
        int b = a;
        b = 15;
        Console.WriteLine(a);


        int[] sayilar = { 10, 20, 30, 40, 50 };
        int[] numbers = sayilar;
        numbers[1] = 60; 

        Console.WriteLine(sayilar[1]);


        string x = "murat";
        string y = x;


        Console.WriteLine(x.GetHashCode());
        Console.WriteLine(y.GetHashCode());
         
        y = "marut";

        Console.WriteLine(x.GetHashCode());
        Console.WriteLine(y.GetHashCode());

        Console.WriteLine(x);
    }
}