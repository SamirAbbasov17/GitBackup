namespace OOP.Struct_.Models;
public class Kitap : BaseEntity
{
    public Kitap() { }

}

public class BaseEntity
{
    public int Id { get; set; }
    public string? Adi { get; set; }
    public DateTime BasimYili { get; set; }
    public string? YazarAdi { get; set; }
    public int SayfaAdet { get; set; }
    public string ISBNNo { get; set; } = null!;
    public string YayinEvi { get; set; } = null!;
}


public struct BaseModel
{
    public int Id { get; set; }
    public string? Adi { get; set; }
    public DateTime BasimYili { get; set; }
    public string? YazarAdi { get; set; }
    public int SayfaAdet { get; set; }
    public string ISBNNo { get; set; }
    public string YayinEvi { get; set; }
}


//public struct Book : BaseModel
//{
//    public int Id { get; set; }
//    public string Adi { get; set; }
//    public DateTime BasimYili { get; set; }
//    public string YazarAdi { get; set; }
//    public int SayfaAdet { get; set; }
//    public string ISBNNo { get; set; }
//    public string YayinEvi { get; set; }
//}
