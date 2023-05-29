using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace OOP.Enum_.Models;



public enum Status : byte
{
    None = 0,


    [Display(Name = "Aktif Kullanıcıları Listeler")]
    Active = 1,


    [Display(Name = "Pasif Kullanıcıları Listeler")]
    Passive,


    [Display(Name = "Silinmiş Kullanıcıları Listeler")]
    Deleted,


    [Display(Name = "Kaydını Dondurmuş Kullanıcıları Listeler")]
    Holiday
}
// -> Enum Adi -> Enum Display Değeri
// Active  -> Aktif Kullanıcıları Listeler
// Passive -> Pasif Kullanıcıları Listeler
public enum CustomerType
{
    None = 0,
    Kurumsal,
    Bireysel
}
public enum Renk
{
    N_o_n_e,
    Siyah,
    Beyaz,
    Kirmizi
}


[Flags] // Enum içerisinde flags nedir?, ne için kullanırız :)
public enum Sehirler
{
    None = 0,
    Adana = 1,
    Adiyaman = 2,
    Afyon = 4,
    Ankara = 6,
    Istanbul = 8,
    Kırıkkale = 16,
    Eleman = 32,
    YeniEleman = 64,
    Antalya = Adana + Ankara
}





public class Customer
{
    /// <summary>
    /// 1) Active
    /// 2) Passive
    /// 3) Deleted
    /// 4) Holiday
    /// </summary>
    public Status Status { get; set; }
    public CustomerType Type { get; set; }
    public Renk SacRenk { get; set; }


}
