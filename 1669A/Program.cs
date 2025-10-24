using System;

namespace _1669A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int rate = int.Parse(Console.ReadLine());
                Console.WriteLine(Rating(rate));
            }
        }

        static string Rating(int rate)
        {
            return rate <= 1399 ? "Division 4" :
                rate <= 1599 ? "Division 3" :
                rate <= 1899 ? "Division 2" : "Division 1";
        }
    }
}
