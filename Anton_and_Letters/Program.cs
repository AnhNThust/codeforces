using System;
using System.Collections.Generic;

namespace Anton_and_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(DistinctLetters(s));
            Console.ReadLine();
        }

        static int DistinctLetters(string s)
        {
            int len = s.Length;
            if (len < 4) return len - 2;

            List<char> list = new List<char>();
            for (int i = 1; i < len - 1; i++)
            {
                if (s[i] < 'a' || s[i] > 'z' || list.Contains(s[i])) continue;
                list.Add(s[i]);
            }
            return list.Count;
        }
    }
}
