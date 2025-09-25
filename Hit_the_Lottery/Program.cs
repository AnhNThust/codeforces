using System;

namespace Hit_the_Lottery
{
    class Program
    {
        /// <summary>
        /// option 1: using "greedy"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] m = { 100, 20, 10, 5, 1 };
            int i = 0;
            int count = 0;
            while (n > 0)
            {
                if (n < m[i])
                {
                    i++;
                    continue;
                }

                count += (n / m[i]);
                n %= m[i];
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
