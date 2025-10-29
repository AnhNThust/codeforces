using System;

namespace _1760A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int[] ns = new int[3];
                ns[0] = int.Parse(s[0]);
                ns[1] = int.Parse(s[1]);
                ns[2] = int.Parse(s[2]);
                Array.Sort(ns);
                Console.WriteLine(ns[1]);
            }
        }
    }
}
