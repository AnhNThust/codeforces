using System;

namespace _32B
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().Replace("--", "2").Replace("-.", "1").Replace(".", "0");
            Console.WriteLine(s);
        }
    }
}
