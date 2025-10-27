using System;

namespace _1899A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 3 == 0)
                    Console.WriteLine("Second");
                else
                    Console.WriteLine("First");
            }
        }
    }
}
