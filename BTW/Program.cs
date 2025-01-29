using System.Reflection;

namespace BTW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prijs = 20;
            const double BTW = 21.0;
            double totaal = prijs * BTW;
            Console.WriteLine($"{prijs} 20 euro zonder btw.Met BTW:{totaal}  euro.)
        }
    }
}
