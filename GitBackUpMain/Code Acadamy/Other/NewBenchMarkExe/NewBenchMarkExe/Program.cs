using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Diagnostics;
using System.Text;

namespace NewBenchMarkExe
{
    internal class Program
    {

        public static string SBuilder()
        {


            string table = "";
            StringBuilder builder = new(table);
            for (int i = 0; i < 100; i++)
            {
                builder.AppendLine($"salam\n");

            }
            builder.AppendLine(".");
            return table;
        }


        public static string SSimple()
        {

            string table = "";
            for (int i = 0; i < 100; i++)
            {
                table += "salam\n";

            }
            table += ".";
            return table;
        }

        static void Main(string[] args)
        {


          


            int tests = 1000;

            Console.WriteLine("| Method |     Mean |");
            Console.WriteLine("|------- |---------:|");

            Stopwatch stopwatch = new Stopwatch();
            //warm up
            SBuilder();

            stopwatch.Start();
            for (int i = 0; i < tests; i++)
            {
                SBuilder();
            }
            stopwatch.Stop();

            var result2 = (double)stopwatch.ElapsedMilliseconds / tests;
            Console.WriteLine($"| Sha512 | {result2} us|");

            //warm up
            SSimple();
            stopwatch.Restart();

            stopwatch.Start();
            for (int i = 0; i < tests; i++)
            {
                SSimple();
            }
            stopwatch.Stop();

            var result1 = (double)stopwatch.ElapsedMilliseconds / tests;

            Console.WriteLine($"| Md5    | {result1} us|");


        }




    }
}