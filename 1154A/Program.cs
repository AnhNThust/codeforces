using System;

namespace _1154A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int len = s.Length;
            int[] n = new int[len];
            for (int i = 0; i < len; i++)
            {
                n[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < len - 1; i++)
            {
                if (n[i] < n[i + 1]) continue;

                int temp = n[i];
                n[i] = n[i + 1];
                n[i + 1] = temp;
            }

            Console.WriteLine($"{n[3] - n[2]} {n[3] - n[1]} {n[3] - n[0]}");
            Console.ReadLine();
        }
    }
}
