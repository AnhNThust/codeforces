using System;
using System.Collections.Generic;

namespace _1352A
{
    class Class1
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] s = new string[t];
            string[] res = new string[t];
            for (int i = 0; i < t; i++)
            {
                s[i] = Console.ReadLine();
                int len = s[i].Length;
                for (int j = 0; j < len; j++)
                {
                    if (s[i][j] == '0') continue;
                    int n = (s[i][j] - '0') * (int)Math.Pow(10, len - j - 1);
                    res[i] += $"{n} ";
                }
            }

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(res[i].Trim().Split().Length);
                Console.WriteLine(res[i]);
            }
            Console.ReadLine();
        }
    }
}