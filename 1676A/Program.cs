using System;

namespace _1676A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string s = Console.ReadLine();
                int sum1 = 0;
                int sum2 = 0;
                for (int j = 0; j < 6; j++)
                {
                    if (j < 3)
                        sum1 += (s[j] - '0');
                    else
                        sum2 += (s[j] - '0');
                }
                if (sum1 == sum2)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
