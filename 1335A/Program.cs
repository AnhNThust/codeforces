using System;

namespace _1335A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int[] res = new int[t];
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                    res[i] = n / 2 - 1;
                else
                    res[i] = n / 2;
            }

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadLine();
        }
    }
}
