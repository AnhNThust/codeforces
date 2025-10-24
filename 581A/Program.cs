using System;

namespace _581A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            Console.Write(a < b ? a : b);
            int c = Math.Abs(a - b);
            Console.Write($" {c / 2}");
            Console.ReadLine();
        }
    }
}
