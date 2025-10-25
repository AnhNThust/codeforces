using System;

namespace _1409A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                Console.WriteLine(NumMove(a, b));
            }
        }

        static int NumMove(int x, int y)
        {
            int z = x > y ? x - y : y - x;
            if (z < 1) return 0;
            if (z <= 10) return 1;
            return z % 10 == 0 ? z / 10 : z / 10 + 1;
        }
    }
}
