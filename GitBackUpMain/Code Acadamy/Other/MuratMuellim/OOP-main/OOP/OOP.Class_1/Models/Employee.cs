using System.ComponentModel.DataAnnotations.Schema;

namespace OOP.Class_1.Models;
public class Employee  // class'ın accessmodifier değeri belirtilmediyse, default değeri -> internal ( aynı assembly içerisinden ulaşılabilir, farklı bir proje veya assembly'ye kapalıdır. (local) (intranet)
{

    // class içerisinde yer alan nesneler (property, field, functions. vb.) yapılar, accessmodifier belirtilmediyse, default değeri -> private olarak işaretlidir. sadece sınıf içerisinden ulaşılabilir.


    // private olarak işaretlendiğinden dolayı, sadece sınıf içerisinden ulaşabilirsiniz.
    //string FirstName;
    //string LastName;
    //string Mail;
    //string Address;
    //string City;
    //DateTime BirthDate;
    //DateTime HireDate;
    //string Linkedin;
    //byte Age;


    // public ->sınıf içerisinden, dışarısından ve farklı assembly içerisinden ulaşabilirsiniz.
    //public string FirstName;
    //public string LastName;
    //public string Mail;
    //public string Address;
    //public string City;
    //public DateTime BirthDate;
    //public DateTime HireDate;
    //public string Linkedin;
    //public byte Age;

    public string FirstName { get; set; }
    public string LastName { get; set; }


    [NotMapped]  // ef işlemlerinde bu propery ile ilgili işlem yapmaz
    public string Mail { get => $"{this.FirstName}.{this.LastName}@code.edu.az".ToLower(); }

    public string Address { get; set; }
    public string City { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime HireDate { get; set; }
    public string Linkedin { get; set; }

    // encapsulation
    private byte _age;
    public byte Age
    {
        get => _age;
        set
        {
            if (value < 18)
            {
                throw new Exception("18 yaş altı işlem yapamaz");
            }
            _age = value;
        }
    }


    // property üzerinde, get ve set metodu var ise, okuyabilir ve yazabilirsiniz.
    // get -> property üzerindeki değeri okuyabilirsiniz
    // set -> property'e değer atayabilirsiniz.





























    //private int _yas;  // value
    ////public void YasSet(int yas)
    ////{
    ////    _yas = yas;
    ////}

    //public int YasGet()
    //{
    //    return _yas;
    //}

}
