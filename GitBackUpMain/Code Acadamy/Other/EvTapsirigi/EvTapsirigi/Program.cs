namespace EvTapsirigi
{
    using Enumm;
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var enums in Enum.GetNames(typeof(Status))) {
                Status status = (Status)Enum.Parse(typeof(Status), enums);
                Console.WriteLine(enums + " -> "+status.GetDisplayName());
            }


            Console.WriteLine(Cities.Sumqayit | Cities.Baki);

        }
    }
}