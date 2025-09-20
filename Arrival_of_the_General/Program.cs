using System;

namespace Arrival_of_the_General
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int imax = 0;
            int imin = n - 1;
            int max = Int32.Parse(input[imax]);
            int min = Int32.Parse(input[imin]);

            for (int i = 1, j = n - 2; i < n; i++)
            {
                int ni = Int32.Parse(input[i]);
                int nj = Int32.Parse(input[j]);

                if (ni > max)
                {
                    max = ni;
                    imax = i;
                }

                if (nj < min)
                {
                    min = nj;
                    imin = j;
                }
                j--;
            }

            if (imax < imin)
                Console.WriteLine(n - 1 - imin + imax);
            else
                Console.WriteLine(n - 2 - imin + imax);
            Console.ReadLine();
        }
    }
}
