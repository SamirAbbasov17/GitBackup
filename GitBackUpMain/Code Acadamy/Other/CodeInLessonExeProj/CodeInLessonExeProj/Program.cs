namespace CodeInLessonExeProj
{
    using Models;
    using Spectre.Console;


    internal class Program
    {

        #region MyRegion
        //public static class ClassToDictionary
        //{
        //    public static Dictionary<string, object> ToDictionary<T>(this T classes) where T : class, new()
        //    {

        //        Dictionary<string, object> newDictionary = new Dictionary<string, object>();

        //        foreach (var item in classes.GetType().GetProperties())
        //        {
        //            newDictionary.Add(item.Name, item.GetValue(classes));
        //        }
        //        return newDictionary;
        //    }
        //}



        //public static void WriteToConsole<T>(List<T> entities) where T : IEntity
        //{
        //    foreach (var entity in entities)
        //    {
        //        foreach (var property in entity.GetType().GetProperties())
        //        {
        //            Console.WriteLine($"{property.Name,-15} : {property.GetValue(entity)}");
        //        }
        //    }
        //}

        //public static void GenerateClass<T>(Dictionary<T,T> entities) where T : IEntity
        //{
        //    foreach (var entity in entities)
        //    {
        //        foreach (var property in entity.GetType().GetProperties())
        //        {
        //            Console.WriteLine($"{property.Name,-15} : {property.GetValue(entity)}");
        //        }
        //    }
        //}


        //public static void WriteToConsole<T>(List<T> entities) where T : IEntity
        //{


        //}


        //    public static void WriteToConsole(List<Product> entities)
        //{   
        //    foreach (var entity in entities)
        //    {
        //        foreach (var property in entity.GetType().GetProperties())
        //        {
        //            Console.WriteLine($"{property.Name,-15} : {property.GetValue(entity)}");
        //        }
        //    }
        //}
        //public static void WriteToConsole(List<Category> entities)
        //{
        //    foreach (var entity in entities)
        //    {
        //        foreach (var property in entity.GetType().GetProperties())
        //        {
        //            Console.WriteLine($"{property.Name,-15} : {property.GetValue(entity)}");
        //        }
        //    }
        //}

        //public static T GenerateClass<T>(Dictionary<string, object> document) where T : class, new()
        //{
        //    T value = new();

        //    foreach (var item in value.GetType().GetProperties())
        //    {
        //        foreach (var key in document)
        //        {
        //            if ( item.Name ==key.Key )
        //            {
        //                item.SetValue(value,key.Value);
        //            }
        //        }
        //    }
        //    return value;
        //}


        #endregion

        public static void DelegateVoidMethodV1(string text) { Console.WriteLine(text); }
        public static void DelegateVoidMethodV2(string text) { Console.WriteLine(text); }
        public static string DelegateStringMethodV1(string text)
        {
            Console.WriteLine($"DelegateStringMethodV1 -> {text}");
            return text;
        }
        public static string DelegateStringMethodV2(string text) => $"DelegateStringMethodV2 -> {text}";
        public static string FunctionReturnMethod() => "https://contoso.com";







        public static string toMail(string isim, string soyisim) => $"{isim}.{soyisim}@code.edu.az";
        public static string toCard(string isim, string soyisim) => $"FirstName: {isim,-10}\nLastName: {soyisim,-10}";
        public static string toSaveDb(string isim, string soyisim) => $"FirstName: {isim,-10}\nLastName: {soyisim,-10}\n Added";
        public static string toUpdateDb(string isim, string soyisim) => $"FirstName: {isim,-10}\nLastName: {soyisim,-10}\n Updateded";



        public delegate string SavePersonToCompany(string isim, string soyisim);

        public static void CreatePerson(string isim, string soyisim)
        {
            var create = new SavePersonToCompany(toMail);
            create += toCard;
            create += toSaveDb;
            create.Invoke(isim,soyisim);
        }


        public static void UpdatePerson(string isim, string soyisim)
        {
            var update = new SavePersonToCompany(toMail);
            update += toCard;
            update += toUpdateDb;
            update.Invoke(isim, soyisim);
        }




        public delegate string DelegateFunction(string text);
        public delegate void DelegateFunctionVoid(string text);








        public static Func<string,bool> CustomControl(string param)
        {
            Console.WriteLine(param);
            return x => x.Length > 10 && x.Length < 20;
        }




        static void Main(string[] args)
        {
            #region 2

            //Dictionary<string, string> employee = new()
            //{
            //    {"FirstName","Samir" },
            //    {"LastName","Abbasov" },
            //    {"Mail","abbasovsamir718@gmail.com" },
            //    {"Phone","+994556922065" }
            //};



            //WriteToConsole(Product.Products);
            //Console.WriteLine("-------------------------------------");
            //WriteToConsole(Category.Categories);
            //Console.WriteLine("-------------------------------------");
            //WriteToConsole(new List<int>() { 1,2,3,4,5});





            //Dictionary<string, object> employee = new()
            //{
            //    {"FirstName","Murat" },
            //    {"LastName","Vuranok" },
            //    {"Mail","murat.vuranok@code.edu.az"},
            //    {"Phone","+905323520997" }
            //};

            //Dictionary<string, object> categories = new()
            //{
            //    {"CategoryId", 1 },
            //    {"CategoryName","Beverages" },
            //    {"Description","Sweet and savory sauces" }
            //};

            //Dictionary<string, object> products = new()
            //{
            //    {"Id ",1 },
            //    {"Name","Chai" },
            //    {"Price",18.00M },
            //    {"UnitsInStock", 39 }
            //};


            ////GenerateClass<Employee>(employee);
            ////GenerateClass<Category>(categories);
            ////GenerateClass<Product>(products);

            //Employee value = new Employee()
            //{
            //    FirstName = "Samir",
            //    LastName = "Abbasov",
            //    Mail = "abbasovsamir718@gmail.com",
            //    Phone = "+994556922065"
            //};

            //value.ToDictionary();

            #endregion

            DelegateFunction _delegate = DelegateStringMethodV1;
            _delegate.Invoke("Delegate metot calisti");

            DelegateFunctionVoid dVoid = new DelegateFunctionVoid(DelegateVoidMethodV1);
            dVoid += DelegateVoidMethodV2;
            dVoid.Invoke("Void Method");


            CreatePerson("Abbasov", "Samir");
            UpdatePerson("Abbasov", "Samir");

            CustomControl("code.edu.az");


        }


    }
}