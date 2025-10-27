using System;

namespace _1399A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split(' ');
                int[] ns = new int[s.Length];
                
                for (int j = 0; j < s.Length; j++)
                {
                    ns[j] = int.Parse(s[j]);
                }
                Console.WriteLine(RemoveSmallest(ns));
            }
        }

        static string RemoveSmallest(int[] arr)
        {
            if (arr.Length <= 1) return "YES";

            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (Math.Abs(arr[i] - arr[i + 1]) <= 1)
                {
                    continue;
                }
                else
                    return "NO";
            }
            return "YES";
        }
    }
}
