using System;

namespace George_and_Accommodation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] input;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                int p = Int32.Parse(input[0]);
                int q = Int32.Parse(input[1]);

                //if (q - p < 2) continue;
                //count++;
                if (q - p >= 2) continue;
                count++;
            }
            Console.WriteLine(n - count);
            Console.ReadLine();
        }
    }
}
