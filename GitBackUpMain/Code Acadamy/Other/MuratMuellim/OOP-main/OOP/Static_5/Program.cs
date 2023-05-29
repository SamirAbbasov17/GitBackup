namespace OOP.Static_;
using Models;

public static class Program
{
    public static void Main(String[] args)
    {
        Kutuphane kitapxana = new();
        //kitapxana.ConnectionString = "yeni connection";

        //ConnectionHelpers helper = new();

        string dbConenction = ConnectionHelpers.SqlConnection;
        string excelConnection = ConnectionHelpers.ExcelConnection;
        //ConnectionHelpers.ExcelConnection = "sdsadasdasdsada";
        //ConnectionHelpers help = new();
        //help.



        //Helpers helpers = new();
        string metin = "    Murat V$U#R;A,N/OK  ";
        //metin = Helpers.MyLower(metin);
        metin = metin.MyLower();


        Console.WriteLine(metin);
    }
}