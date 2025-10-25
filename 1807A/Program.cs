using System;

namespace _1807A
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
                int c = int.Parse(s[2]);
                if (a + b == c)
                    Console.WriteLine('+');
                else
                    Console.WriteLine('-');
            }
        }
    }
}
