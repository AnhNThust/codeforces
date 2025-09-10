using System;

namespace Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int len = s.Length;
            int count = 0; // dem so chu cai thuong
            for (int i = 0; i < len; ++i)
            {
                if (char.IsUpper(s[i])) continue;
                count++;
            }

            if (count >= (float)len / 2)
                Console.WriteLine(s.ToLower());
            else
                Console.WriteLine(s.ToUpper());
            Console.ReadLine();
        }
    }
}
