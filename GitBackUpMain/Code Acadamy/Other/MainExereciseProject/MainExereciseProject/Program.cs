using Spectre.Console;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Text;
using MainExereciseProject.Models;

namespace MainExereciseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Piyano piyano = new();
            piyano.Brand = "Yamaha";
            piyano.Model = "Yamaha CFX Akustik Tam Kuyruklu Piyano";
            piyano.Price = 3.88232100M;
            piyano.Length = "9′ 0″";

            Muzisyen piyanist = new();
            piyanist.FirstName = "Hamza";
            piyanist.LastName = "Piyanosoy";
            piyanist.Enstruman = piyano;


            Muzisyen kemanci = new()
            {
                FirstName = "Hamza",
                LastName = "Kemansoy",
                Enstruman = new Keman
                {
                    Brand = "Yamaha",
                    Model = "Yamaha YSV104BRO Silent Keman (Kahverengi)",
                    Price = 38.03400M,
                    Arse = "Hao Yun HVB92 4/4 Keman Arşesi"
                }
            };


            Muzisyen gitarci = new()
            {
                FirstName = "Hamza",
                LastName = "Gitarsoy",
                Enstruman = new Gitar
                {
                    Brand = "Hyz_Yamaha",
                    MagneticArray = "BcQh-12K",
                    Model = "Electro18_2",
                    Price = 27148924M
                }
            };


            Muzisyen flutcu = new()
            {
                FirstName = "Hamza",
                LastName = "Fülütsoy",
                Enstruman = new YanFulut
                {
                    Brand = "Fluuter19",
                    Model = "Kcs13-2B",
                    Price = 948145M,
                    Material = "Ahsab"
                }
            };



            var muzisyenler = new ArrayList();
            muzisyenler.Add(piyanist);
            muzisyenler.Add(kemanci);
            muzisyenler.Add(gitarci);
            muzisyenler.Add(flutcu);

            foreach (var muzisyen in muzisyenler)
            {
                StringBuilder sb = new();
                sb.Append($"{muzisyen.GetType().Name}");
                sb.AppendLine();

                foreach (var property in muzisyen.GetType().GetProperties())
                {
                    if (property.PropertyType.Name != nameof(Enstruman))
                    {
                        sb.Append($"{" ",10}{property.Name,-20} : {property.GetValue(muzisyen)}");
                        sb.AppendLine();
                    }
                    else
                    {
                        sb.AppendLine(property.Name);
                        var item = property.GetValue(muzisyen, null);

                        foreach (var enstruman in item.GetType().GetProperties())
                        {
                            sb.Append($"{" ",10}{enstruman.Name,-20} : {enstruman.GetValue(item)}");
                            sb.AppendLine();
                        }


                        var functions = item.GetType()
                            .GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public)
                            .Where(x => !x.Name.StartsWith("get") && !x.Name.StartsWith("set"))
                            .ToList();

                        foreach (var function in functions)
                        {
                            var val = function.Invoke(item, null);
                            sb.Append($"{" ",10}{function.Name,-20} : {val}");
                            sb.AppendLine();
                        }
                    }
                }
                sb.AppendLine();
                sb.AppendLine($"{new string('-', 100)}");
                sb.AppendLine();

                Console.WriteLine(sb.ToString());
            }





            //TableStart


            //var root = new Tree("RNET 102").Guide(TreeGuide.BoldLine).Style("red");

            //// Add some nodes

            ////Muzisyen
            //var foo = root.AddNode("[green]Müzisyen[/]");
            //var _table = new Table().RoundedBorder().BorderStyle(new Style(foreground: Spectre.Console.Color.Red, decoration: Decoration.Strikethrough));
            
            //var props = piyanist.GetType().GetProperties()
            //    .OrderBy(x => x.Name);

            //var names = props
            //    .Select(x => x.Name)
            //    .ToList();

            //var values = props
            //    .Select(x => x.GetValue(piyanist).ToString())
            //    .ToArray();

            //names.ForEach(x => _table.AddColumn(x));

            //var table = foo.AddNode(_table);
            //_table.AddRow(values);

            ////Enstruman
            //var soo = foo.AddNode($"[green]Enstruman : {piyano.GetType().Name}[/]");

            //var subtable = new Table().RoundedBorder().BorderStyle(new Style(foreground: Spectre.Console.Color.Red, decoration: Decoration.Strikethrough));

            //var subprops = piyano.GetType().GetProperties()
            //    .OrderBy(x => x.Name);

            //var subnames = subprops
            //    .Select(x => x.Name)
            //    .ToList();

            //var subvalues = subprops
            //    .Select(x => x.GetValue(piyano).ToString())
            //    .ToArray();

            //subnames.ForEach(x => subtable.AddColumn(x));

            //var mainsubtable = soo.AddNode(subtable);
            //subtable.AddRow(subvalues);

      








            var root = new Tree("RNET 102").Guide(TreeGuide.BoldLine).Style("red");


            //var subtable = new Table().RoundedBorder().BorderStyle(new Style(foreground: Spectre.Console.Color.Red, decoration: Decoration.Strikethrough));

            
            foreach (var muzisyen in muzisyenler)
            {
                var foo = root.AddNode("[green]Müzisyen[/]");
                var _table = new Table().RoundedBorder().BorderStyle(new Style(foreground: Spectre.Console.Color.Red, decoration: Decoration.Strikethrough));



                var props = muzisyen.GetType().GetProperties().OrderBy(x => x.Name);
                
                var names = props
                    .Select(x => x.Name)
                    .ToList();
                
                var values = props
                    .Select(x => x.GetValue(muzisyen).ToString())
                    .ToArray();
                
                names.ForEach(x => _table.AddColumn(x));
                var table = foo.AddNode(_table);
                _table.AddRow(values);


                foreach (var property in muzisyen.GetType().GetProperties())
                {

                    if (property.PropertyType.Name == nameof(Enstruman))
                    {


                        var item = property.GetValue(muzisyen, null);

                        var soo = foo.AddNode($"[green]Enstruman : {item.GetType().Name}[/]");

                        var subtable = new Table().RoundedBorder().BorderStyle(new Style(foreground: Spectre.Console.Color.Red, decoration: Decoration.Strikethrough));

                        var subprops = item.GetType().GetProperties()
                            .OrderBy(x => x.Name);

                        var subnames = subprops
                            .Select(x => x.Name)
                            .ToList();

                        var subvalues = subprops
                            .Select(x => x.GetValue(item).ToString())
                            .ToArray();

                        subnames.ForEach(x => subtable.AddColumn(x));

                        var mainsubtable = soo.AddNode(subtable);
                        subtable.AddRow(subvalues);



                    }
                }

            }

            AnsiConsole.Write(root);

        }
    }
}