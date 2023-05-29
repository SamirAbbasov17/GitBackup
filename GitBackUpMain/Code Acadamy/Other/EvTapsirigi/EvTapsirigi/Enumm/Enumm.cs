using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EvTapsirigi.Enumm
{

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

    [Flags]
    public enum Cities : byte
    {
       None,
       Baki,
       Gence,
       Sumqayit,
       Qebele,
       Samaxi,
       Gedebey,
       Beyleqan,
       Zerdab,
    }


    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            string displayName;
            displayName = enumValue.GetType()
                .GetMember(enumValue.ToString())
                .FirstOrDefault()
                .GetCustomAttribute<DisplayAttribute>()?
                .GetName();
            if (String.IsNullOrEmpty(displayName))
            {
                displayName = enumValue.ToString();
            }
            return displayName;
        }
    }
}
