using System;

namespace Wrong_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int n = Int32.Parse(numbers[0]);
            int k = Int32.Parse(numbers[1]);

            for (int i = 0; i < k; ++i)
            {
                if (n % 10 == 0)
                    n /= 10;
                else
                    n--;
            }
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
