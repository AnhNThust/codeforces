using System;
using System.Collections.Generic;

namespace Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int len = s.Length;
            int count = 0;
            //List<int> indexes = new List<int>(); // Luu cac tu la chu cai thuong
            for (int i = 0; i < len; ++i)
            {
                if (char.IsUpper(s[i])) continue;
                count++;
                //indexes.Add(i);
            }

            if (count >= (float)len / 2)
                Console.WriteLine(s.ToLower());
            else
                Console.WriteLine(s.ToUpper());
            Console.ReadLine();
        }
    }
}
