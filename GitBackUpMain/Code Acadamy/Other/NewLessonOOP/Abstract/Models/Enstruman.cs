using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Models
{
    public abstract class Enstruman
    {
        public Enstruman()
        {
            this.Id = Guid.NewGuid(); 
        }
        public Guid Id { get; set; }
        public string? Model { get; set; }
        public string? Brand { get; set; }
        public decimal? Price { get; set; }

        //public virtual string Sound() => "default enstruman sesi";
        public abstract string Sound();

    }

    public class Piano : Enstruman
    {
        public string? Length { get; set; }
        public override string Sound() => "Piyano sesi";

    }
    public class Keman: Enstruman
    {
        public string? Arse { get; set; }

        public override string Sound() => "Keman Sesi";
    }

    public class Gitar : Enstruman
    {
        public string? MagneticArray { get; set; }
        public override string Sound() => "Gitar Sesi";

    }
    public class YanFlut : Enstruman
    {
        public string Material { get; set; }
        public override string Sound() => "YanFlut Sesi";
    }

    public class Muzisyen
    {
        public Muzisyen()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Enstruman? Enstruman { get; set; }

    }
}
