using System;

namespace _151A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int k = int.Parse(s[1]);
            int l = int.Parse(s[2]);
            int c = int.Parse(s[3]);
            int d = int.Parse(s[4]);
            int p = int.Parse(s[5]);
            int nl = int.Parse(s[6]);
            int np = int.Parse(s[7]);

            int drink = k * l / nl;
            int lime = c * d;
            int salt = p / np;
            int min = Math.Min(Math.Min(drink, lime), salt);
            Console.WriteLine(min / n);
            Console.ReadLine();
        }
    }
}
