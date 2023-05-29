using Interface_9.Models;
using System.Collections;
using System.Reflection;

namespace OOP.Interface_;
public static class Program
{
    public static void Main(String[] args)
    {
        //Kaleci kaleci = new();
        //kaleci.Adi = "Tafarel";
        //kaleci.Soyadi = "Tefal";

        Kaleci kaleci = new()
        {
            Adi = "Tafarel",
            Soyadi = "Tefal",
            ElleTopKontrolu = 80,
            BirthTarihi = new DateTime(2000, 12, 12),
            Agresiflik = 10,
            FormaNumarasi = "50",
            Mevki = Mevki.Kale,
            MilliFutbolcu = false,
            SolakMi = false,
            Takim = "Galatasaray",
            TopaUcmaKontrolu = 100,
            TopKontrolu = 100,
            ToplamGolSayisi = 5,
            TopOynabiliyormu = true,
            TransferPulu = 5.000000M,
            Yas = 35
        };

        Forvet forvet = new()
        {
            Adi = "Sabri",
            Soyadi = "Sarıoğlu",
            BirthTarihi = new DateTime(2000, 12, 12),
            Agresiflik = 100,
            FormaNumarasi = "55",
            Mevki = Mevki.Bilinmiyor,
            MilliFutbolcu = true, // malesef
            SolakMi = false,
            Takim = "Galatasaray",
            TopKontrolu = 1,
            ToplamGolSayisi = 5,
            TopOynabiliyormu = false,
            TransferPulu = 0,
            Yas = 35
        };


        Defans defans = new()
        {
            Adi = "Şakir",
            Soyadi = "Sarıoğlu",
            BirthTarihi = new DateTime(2000, 12, 12),
            Agresiflik = 100,
            FormaNumarasi = "55",
            Mevki = Mevki.Bilinmiyor,
            MilliFutbolcu = true, // malesef
            SolakMi = false,
            Takim = "Galatasaray",
            TopKontrolu = 1,
            ToplamGolSayisi = 5,
            TopOynabiliyormu = false,
            TransferPulu = 0,
            Yas = 35
        };


        ArrayList futbolcular = new ArrayList();
        futbolcular.Add(forvet);
        futbolcular.Add(kaleci);
        futbolcular.Add(defans);

        while (true)
        {
            Console.Clear();

            for (int i = 0; i < futbolcular.Count; i++)
            {
                Console.WriteLine($"{i} -> {futbolcular[i]}");
            }

            //IFutbolcu futbolcu = (Kaleci)futbolcular[1];
            //var info = futbolcu.GetInfo();
            //Console.WriteLine(info);

            // Adı    : futbolcu.Adi
            // Soyadı : futbolcu.Soyadi


            Console.Write("Lütfen Seçtiğiniz Futbolcunun Id değerini giriniz : ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index < futbolcular.Count)
                {
                    if (futbolcular[index].GetType().GetInterface(nameof(IFutbolcu)) != null)
                    {
                        IFutbolcu futbolcu = futbolcular[index];  //new objcet()
                        Console.ForegroundColor = ConsoleColor.Green;
                         

                        foreach (PropertyInfo property in futbolcu.GetType().GetProperties())
                        {
                            Console.WriteLine($"{property.Name,-20}: {property.GetValue(futbolcu)}");
                        }
                         
                        Thread.Sleep(5000);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Seçtiğiniz kişi lisanslı bir futbolcu değildir.");
                        Thread.Sleep(1000);
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen bir futbolcu seçiniz");
                    Thread.Sleep(1000);
                    Console.ResetColor();
                }
            }
        }


        //Console.WriteLine("seçtiğiniz futbolcu \n\n" + futbolcular[index]);





        /*
         --------------------------------------------------
         Adı    : Tafarel
         Soyadı : Tefal
         --------------------------------------------------
         */



        #region Old
        //foreach (var futbolcu in futbolcular )
        //{
        //   
        //    //Console.WriteLine(futbolcu );


        //    //if (futbolcu is Kaleci)
        //    //{

        //    //    Kaleci _kaleci = (Kaleci)futbolcu;
        //    //    Console.WriteLine(_kaleci.Adi + " " + _kaleci.Soyadi);
        //    //}

        //    //else if (futbolcu is Forvet)
        //    //{
        //    //    Forvet _forvet = (Forvet)futbolcu;
        //    //    Console.WriteLine(_forvet.Adi + " " + _forvet.Soyadi);
        //    //}


        //    //if (futbolcu is Kaleci _kaleci)
        //    //{
        //    //    Console.WriteLine(_kaleci.Adi + " " + _kaleci.Soyadi);
        //    //}
        //    //else if (futbolcu is Forvet _forvet)
        //    //{
        //    //    Console.WriteLine(_forvet.Adi + " " + _forvet.Soyadi);
        //    //} 
        //   

        //    Console.WriteLine(futbolcu);
        //}
        #endregion
    }

    
}


#region Ornek
//public interface IYazilimEmployee
//{
//    string Teknolojiler { get; set; }
//}

//public interface ISeniorDeveloper : IYazilimEmployee
//{
//    string ProgramlamaDili { get; set; }
//    bool UniversiteMezuniyet { get; set; }
//    bool MCTCertificate { get; set; }
//}

//public interface IJuniorDeveloper : IYazilimEmployee
//{
//    string ProgramlamaDili { get; set; }

//}

//public class SeniorDeveloperATeam : ISeniorDeveloper
//{
//    public string ProgramlamaDili { get; set; } = "C#";
//    public string Teknolojiler { get; set; } = "Api, .net core, mvc  ";
//    public bool UniversiteMezuniyet { get; set; } = true;
//    public bool MCTCertificate { get; set; } = true;

//    public void EkipYonet() { }

//}

//public class JuniorDeveloperTeamB : IJuniorDeveloper
//{
//    public string ProgramlamaDili { get; set; } = "Java";
//    public string Teknolojiler { get; set; } = "Html, Css, JavaScript";

//    public void CayDemle()
//    {

//    }
//} 
#endregion