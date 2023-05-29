using OOP.Struct_.Models;
namespace OOP.Struct_;

public static class Program
{

    //public static Book kitap;
    public static void Main(String[] args)
    {
        //kitap = new();
        Book kitap = new();
        kitap.Adi = "Fakirler";
        kitap.YazarAdi = "Tayyip";
        kitap.SayfaAdet = 1;
        kitap.YayinEvi = "Fakirhane";
        kitap.BasimYili = new DateTime(2023, 1, 1);
        kitap.ISBNNo = "123456";
    }
}

