using System;
namespace Drinks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (input[i] == "0") continue;
                int perI = Int32.Parse(input[i]);
                sum += perI;
            }

            Console.WriteLine(sum / n);
            Console.ReadLine();
        }
    }
}
