using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBenchMarkExe
{
    public class BenchmarkDotNetExample
    {

        [Benchmark]
        public string SBuilder()
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

        [Benchmark]
        public string SSimple() 
        {

            string table = "";
            for (int i = 0; i < 100; i++)
            {
                table += "salam\n";

            }
            table += ".";
            return table;
        }








                

    }
}
