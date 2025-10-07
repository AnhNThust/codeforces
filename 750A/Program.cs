using System;

namespace _750A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int k = int.Parse(s[1]);
            int limit = 240;
            int sum = 0;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (5 * i);
                if (sum + k <= limit)
                    count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
