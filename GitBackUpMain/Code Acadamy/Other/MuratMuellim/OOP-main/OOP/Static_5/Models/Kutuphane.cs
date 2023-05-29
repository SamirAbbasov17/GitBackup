namespace OOP.Static_.Models;


public static class Helpers
{
    public static string MyLower(this string param)
    {
        return param
            .ToLower()
            .Replace(" ", "")
            .Replace("/", "")
            .Replace("%", "")
            .Replace("½", "")
            .Replace("?", "")
            .Replace(";", "")
            .Replace(",", "")
            .Replace("$", "")
            .Replace("#", "");
    }
}




public class Kutuphane { }
public static class ConnectionHelpers
{
    // database, excel, access, mongo vb. uygulamala bağlanmak için anahtar kelime

    // static field
    public static string SqlConnection = "database=testDb;uid=sa;pwd=123;server=.;";

    // static readonly field
    public static readonly string ExcelConnection = "database=testDb;uid=sa;pwd=123;server=.;";

    // static readonly property
    public static string MySqlConnection { get => "mysqlconnection string "; }

    public static string MongoConnection = "database=testDb;uid=sa;pwd=123;server=.;";
    public static string PostqureConnection = "database=testDb;uid=sa;pwd=123;server=.;";
    public static string OracleConnection = "database=testDb;uid=sa;pwd=123;server=.;";

    // const -> kendiliğinden static ve sadece okunabilir olma özelliği vardır. işaretlemenize gerek yoktur :)
    public const string ConnectionString = "";

}

/*
 tüm özel karekterleri temizleyen ve hepsini küçük harfe çeviren extention metot yazınız :)
 */