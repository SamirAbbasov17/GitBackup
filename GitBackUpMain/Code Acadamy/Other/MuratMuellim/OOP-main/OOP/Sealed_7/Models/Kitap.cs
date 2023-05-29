namespace OOP.Sealed_.Models;

public class BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime CreatedDate { get; set; }


    public virtual void SetLog()
    {

        // default olarak, SQL Log yapar.
        // Loglama işlemi yapar
    }

    public virtual string GetCurrentUser()
    {
        return Environment.UserName;
    }
}



// sealed ->  class'ı sealed olarak işaretlerseniz, kendisinden instance alabilirsiniz fakat inherit edemezsiniz.
public sealed class Category : BaseEntity
{
    public string? Description { get; set; }
    public ICollection<Product>? Products { get; set; }

    public override void SetLog()
    {
        // += Mail , sms
        base.SetLog();
    }
}

public class Shipper : BaseEntity
{
    public string? Description { get; set; }

    public override string GetCurrentUser()
    {
        return "Shipper Current User -> " + base.GetCurrentUser();
    }
}



public class Book : BaseEntity
{
    public string ISNNNo { get; set; }


    // sealed -> bir metot için kullandığınızda, bir sonraki inherit ettiğiniz sınıf içerisinde override edemezsiniz. :)
    public sealed override string GetCurrentUser()
    {
        //return "Kitap sınıfı için kullanıcı bilgisi -> " + base.GetCurrentUser();
        return base.GetCurrentUser();
    }
}

public sealed class Hikaye : Book
{
}
public sealed class Roman : Book { }
public sealed class Yemek : Book { }
public sealed class KisiselGelisim : Book { }





public class Product : BaseEntity { }
