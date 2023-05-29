using OOP.Enum_.Models;
using System.Drawing;

namespace OOP.Enum_;

public static class Program
{
    public static void Main(String[] args)
    {
        //var sehirler = Enum.GetNames(typeof(Sehirler));
        //foreach (var item in sehirler)
        //{
        //    Console.WriteLine(item);
        //}

        if (Enum.IsDefined(typeof(Sehirler), 9))
            Console.WriteLine((Sehirler)6);
        else
        {
            Console.WriteLine("Eleman Yok :)");
        }
        //Console.WriteLine("Lütfen Renk Seçiniz : ");


        //var colors = Enum.GetNames(typeof(Renk));
        //foreach (var rn in colors)
        //{
        //    Console.WriteLine(rn);
        //}


        //Console.Write("Seçim : ");

        //string renk = Console.ReadLine();
        //Console.WriteLine("seçtiğiniz renk " + renk);




        //Customer customer = new Customer();
        //customer.Status = Status.Active;
        //customer.Type = CustomerType.Kurumsal;
        ////customer.SacRenk = Renk.Beyaz;
        //customer.SacRenk = (Renk)Enum.Parse(typeof(Renk), renk);



        //Console.WriteLine("Müşterinin Saç Rengi " + customer.SacRenk);

        //// Delete()
        //Customer customer = new Customer();
        //customer.Status = Status.Deleted;
        //// Update()
        //customer.Type = 1;



        //switch (customer.Status)
        //{
        //    case Status.None:
        //        break;
        //    case Status.Active:
        //        break;
        //    case Status.Passive:
        //        // Set Passive and Update
        //        break;
        //    case Status.Deleted:
        //        // Delete Function
        //        break;
        //    case Status.Holiday:
        //        // Çiçek yolla
        //        break;
        //    default:
        //        break;
        //}
    }
}