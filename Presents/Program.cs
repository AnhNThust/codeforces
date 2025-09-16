using System;

namespace Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] p = Console.ReadLine().Split(' ');
            string[] q = new string[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p.Length; j++)
                {
                    if ((i + 1) != Int32.Parse(p[j])) continue;
                    q[i] = $"{j + 1}";
                    break;
                }
            }

            for (int i = 0; i < n; i++)
                Console.Write($"{q[i]} ");
            Console.ReadLine();
        }
    }
}
