using System;

namespace _1692A
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
                int count = 0;
                for (int j = 1 ; j < 4; j++)
                {
                    int n = int.Parse(s[j]);
                    if (n > a)
                        count++;
                }
                Console.WriteLine(count);
            }
        }
    }
}
