
using Ganss.Excel;

namespace ExcelMapperr
{
    public enum DiscountBandEnum
    {
        None,
        Low,
        Medum,
        High
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\Lenovo\Desktop\Code Acadamy\Other\ExcelMapper\ExcelMapper\example_data.xlsx";
            var datas = new ExcelMapper(file).Fetch<ExcelData>();
            foreach (ExcelData data in datas)
            {
                Console.WriteLine(data.Segment);
            }
        }


    }
    public class ExcelData
    {
        public string Segment { get; set; }
        public string Country { get; set; }
        public string Product { get; set; }
        public DiscountBandEnum DiscountBand { get; set; }
        public double Units_Sold { get; set; }
        public string Manufacturing_Price { get; set; }
        public string Sale_Price { get; set;}
        public string Gross_Sales { get; set; }
        public string Discounts { get; set; }
        public string Sales { get; set; }
        public string COGS { get; set; }
        public string Profit { get; set; }
        public string Date { get; set; }


    }
}