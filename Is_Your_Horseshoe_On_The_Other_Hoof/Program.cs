using System;
using System.Collections.Generic;

namespace Is_Your_Horseshoe_On_The_Other_Hoof
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<string> l = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (l.Contains(input[i])) continue;
                l.Add(input[i]);
            }
            Console.WriteLine(4 - l.Count);
            Console.ReadLine();
        }
    }
}
