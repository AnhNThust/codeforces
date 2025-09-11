using System;

namespace Vanya_And_Fence
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(' '); // n & h
            string[] input2 = Console.ReadLine().Split(' '); // n (ai)
            int n = Int32.Parse(input1[0]);
            int h = Int32.Parse(input1[1]);
            int res = 0;
            for (int i = 0; i < n; ++i)
            {
                int hei = Int32.Parse(input2[i]);
                if (hei <= h) res += 1;
                else res += 2;
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
