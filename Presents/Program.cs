using System;
using System.Collections.Generic;

namespace Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] p = Console.ReadLine().Split(' ');
            string[] q = Console.ReadLine().Split(' ');
            List<string> list = new List<string>();
            for (int i = 1; i <= n; i++)
                list.Add($"{i}");

            for (int i = 1; i < p.Length; i++)
            {
                if (!list.Contains(p[i])) continue;
                else if (list.Count <= 0) break;
                list.Remove(p[i]);
            }

            for (int i = 1; i < q.Length; i++)
            {
                if (!list.Contains(q[i])) continue;
                else if (list.Count <= 0) break;
                list.Remove(q[i]);
            }

            if (list.Count > 0) Console.WriteLine("Oh, my keyboard!");
            else Console.WriteLine("I become the guy.");
        }
    }
}
