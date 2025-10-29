using System;

namespace _1791A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string s = "codeforces";
            for (int i = 0; i < t; i++)
            {
                string c = Console.ReadLine();
                if (s.IndexOf(c) > -1)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
