using System;

namespace Divisibility_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Int32.Parse(Console.ReadLine());
            int[] res = new int[t];
            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                res[i] = DivProblem(input);
            }

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadLine();
        }

        static int DivProblem(string[] input)
        {
            int a = Int32.Parse(input[0]);
            int b = Int32.Parse(input[1]);

            if (a <= b) return b - a;

            if (a % b == 0) return 0;

            return (a / b + 1) * b - a;
        }
    }
}
