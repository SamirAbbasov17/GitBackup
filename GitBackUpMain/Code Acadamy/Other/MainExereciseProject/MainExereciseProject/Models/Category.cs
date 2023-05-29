using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MainExereciseProject.Models
{
    class Category
    {

    }
    // abstract -> soyut sınıf, kendisinden instance alınamaz, sadece inherit edilebilir.
    public abstract class Enstruman
    {
        public Enstruman() { this.Id = Guid.NewGuid(); }

        public Guid Id { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public decimal? Price { get; set; }


        // virtual -> opsiyonel olarak değiştirebilirsiniz, zorunlu değildir. ihtiyaç halinde kullanabilirsiniz.
        //public virtual string Sound() => "default enstruman sesi";    

        // abstract -> abstract sınıf içerisinde bir metot veya property abstract olarak işaretlenirse, miras verilen sınıf içerisinde zorunlu olarak override etmeniz gerekir.

        // abstract olarak işaretlenen nesnelerin, gövdeleri olamaz. zorunlu olarak override ettiğiniz için , sınıf içerisinde bu değer atanır.

        public abstract string Sound();
        public abstract string Ses();
        public abstract string Deneme();
        public abstract string Denememeler();
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    public class Piyano : Enstruman
    {
        public string? Length { get; set; }
        public override string Deneme() => $"{this.GetType().Name} (Deneme) Sesi";
        public override string Denememeler() => $"{this.GetType().Name} (Denememeler) Sesi";
        public override string Ses() => $"{this.GetType().Name} (Ses) Sesi";
        public override string Sound() => $"{this.GetType().Name} Sesi";
    }

    public class Keman : Enstruman
    {
        public string? Arse { get; set; }
        public override string Deneme() => $"{this.GetType().Name} (Deneme) Sesi";
        public override string Denememeler() => $"{this.GetType().Name} (Denememeler) Sesi";
        public override string Ses() => $"{this.GetType().Name} (Ses) Sesi";
        public override string Sound() => $"{this.GetType().Name} Sesi";

    }

    public class Gitar : Enstruman
    {
        public string? MagneticArray { get; set; }
        public override string Deneme() => $"{this.GetType().Name} (Deneme) Sesi";
        public override string Denememeler() => $"{this.GetType().Name} (Denememeler) Sesi";
        public override string Ses() => $"{this.GetType().Name} (Ses) Sesi";
        public override string Sound() => $"{this.GetType().Name} Sesi";
    }

    public class YanFulut : Enstruman
    {
        public string? Material { get; set; }
        public override string Deneme() => $"{this.GetType().Name} (Deneme) Sesi";
        public override string Denememeler() => $"{this.GetType().Name} (Denememeler) Sesi";
        public override string Ses() => $"{this.GetType().Name} (Ses) Sesi";
        public override string Sound() => $"{this.GetType().Name} Sesi";
    }


    public class Muzisyen
    {
        public Muzisyen() { this.Id = Guid.NewGuid(); }
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public Enstruman? Enstruman { get; set; }
    }



    public class BaseEntity<T> where
        T : struct, IEquatable<T>
    {
        public T Id { get; set; }
        public virtual string Name { get; set; } = null!;
    }


    public class Category2 : BaseEntity<Guid>
    {

        [Display(Name = "Kategori Adı")]
        public override string Name { get; set; } = null!;

        [Display(Name = "Açıklama")]
        public string? Description { get; set; }
    }





    public class B : BaseEntity<Guid> { }
    public class C : BaseEntity<byte> { }
    public class D : BaseEntity<int> { }
    public class E : BaseEntity<long> { }
}
