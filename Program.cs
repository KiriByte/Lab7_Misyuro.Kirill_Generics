using System.Runtime.InteropServices;

namespace Lab7_Misyuro.Kirill_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pair<int, int> test = new Pair<int, int>(5, 10);
            Console.WriteLine(test.Val1);
            Console.WriteLine(test.Val2);

            ComparablePair<string, string> p = new ComparablePair<string, string>("0123", "b");
            ComparablePair<string, string> q = new ComparablePair<string, string>("09", "2");
            //0-values are equal
            //1-first is greater second
            //2-second is greater first
            switch (p.CompareTo(q))
            {
                case 0:
                    Console.WriteLine("Values are equals");
                    break;
                case 1:
                    Console.WriteLine("First is greater second");
                    break;
                case 2:
                    Console.WriteLine("Second is greater first");
                    break;
            }
        }
    }
}