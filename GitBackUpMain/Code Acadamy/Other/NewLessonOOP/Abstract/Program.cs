namespace Abstract
{
    using Models;
    using System.Collections;
    using System.Reflection;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    internal class Program
    {
        static void Main(string[] args)
        {

            Piano piano = new();
            piano.Brand = "Yamaha";
            piano.Model = "Yamaha CFX Akustik Tam Kuyruklu Piano";
            piano.Price = 3.88232100M;
            piano.Length = "9 inch";


            Muzisyen piyanist = new();
            piyanist.FirstName = "Hamza";
            piyanist.LastName = "Piyanosoy";
            piyanist.Enstruman = piano;




            Muzisyen kemanci = new()
            {
                FirstName = "Hamza",
                LastName = "Kemansoy",
                Enstruman = new Keman
                {
                    Brand = "Yamaha",
                    Model = "SGw-13124",
                    Price = 384582M,
                    Arse = "DAwk1wd"
                }
            };

            Muzisyen gitarci = new()
            {
                FirstName = "Hamza",
                LastName = "Gitarsoy",
                Enstruman = new Gitar
                {
                    Brand = "Yamaha",
                    Model = "1odhsuda-13124",
                    Price = 38412148M,
                    MagneticArray = "aDSHbq-21"
                }
            };

            Muzisyen fulutcu = new()
            {
                FirstName = "Hamza",
                LastName = "Fulutsoy",
                Enstruman = new YanFlut
                {
                    Brand = "Flutter",
                    Model = "UDsaw-13124",
                    Price = 384148M,
                    Material = "Ahsap"


                    
                }
            };




            foreach (var item in kemanci.GetType().GetProperties().OrderBy(x => x.Name))
            {
                // Create a table
                //var table = new Table();

                //// Add some columns
                //table.AddColumn("Foo");
                //table.AddColumn(new TableColumn("Bar").Centered());

                //// Add some rows
                //table.AddRow("Baz", "[green]Qux[/]");
                //table.AddRow(new Markup("[blue]Corgi[/]"), new Panel("Waldo"));

                //// Render the table to the console
                //AnsiConsole.Write(table);
            }

            //Console.WriteLine(kemanci.Enstruman.Sound());


            var muzisyenler = new ArrayList();
            muzisyenler.Add(piyanist);
            muzisyenler.Add(kemanci);
            muzisyenler.Add(gitarci);
            muzisyenler.Add(fulutcu);

            foreach (var muzisyen in muzisyenler)
            {
                Console.WriteLine(muzisyen.GetType().Name + "\n");

                foreach (var property in muzisyen.GetType().GetProperties())
                {
                    if(property.PropertyType.Name != nameof(Enstruman))
                    {
                        Console.WriteLine($"{" ",10}{property.Name,-20} : {property.GetValue(muzisyen)}");
                    }
                    else
                    {
                        Console.WriteLine(property.Name);
                        var items = property.GetValue(muzisyen, null);

                        foreach(var enstruman in items.GetType().GetProperties()) {
                            Console.WriteLine($"{" ",10}{enstruman.Name,-20} : {enstruman.GetValue(items)}");
                            
                        }
                        var functions = items.GetType().GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public).Where(x => !x.Name.StartsWith("get") && !x.Name.StartsWith("set")).ToList();
                        foreach (var function in functions)
                        {
                            var val = function.Invoke(items, null);
                            Console.WriteLine(val);
                        }
                        
                    }
                }
                Console.WriteLine($"\n{new string('-',100)}\n");
            }

                








       
           


   

        }
    }
}