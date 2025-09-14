using System;

namespace Calculating_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine(n / 2);
            else
                Console.WriteLine((-1 - n) / 2);
            
            Console.ReadLine();
        }
    }
}
