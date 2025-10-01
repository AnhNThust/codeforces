using System;
using System.Collections.Generic;

namespace _268A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                list1.Add(s[0]);
                list2.Add(s[1]);
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || list1[i] != list2[j]) continue;
                    count++;
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
