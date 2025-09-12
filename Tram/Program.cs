using System;

namespace Tram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int max = 0;
            int now = 0;
            for (int i = 0; i < n; ++i)
            {
                string[] input = Console.ReadLine().Split(' ');
                int off = Int32.Parse(input[0]);
                int on = Int32.Parse(input[1]);
                now = now - off + on;

                if (now <= max) continue;
                max = now;
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
