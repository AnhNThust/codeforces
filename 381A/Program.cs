using System;

namespace _381A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int[] ns = new int[n];
            for (int i = 0; i < n; i++)
            {
                ns[i] = int.Parse(s[i]);
            }

            int j = 0;
            int k = n - 1;
            int sereja = 0;
            int dima = 0;
            bool isDima = false;
            while (j <= k)
            {
                if (isDima == false)
                {
                    if (ns[j] >= ns[k])
                    {
                        sereja += ns[j];
                        j++;
                    }
                    else
                    {
                        sereja += ns[k];
                        k--;
                    }
                }
                else
                {
                    if (ns[j] >= ns[k])
                    {
                        dima += ns[j];
                        j++;
                    }
                    else
                    {
                        dima += ns[k];
                        k--;
                    }
                }
                isDima = !isDima;
            }

            Console.WriteLine($"{sereja} {dima}");
        }
    }
}