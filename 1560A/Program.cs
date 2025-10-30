using System;

namespace _1560A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int index = 0;
                int num = 0;
                int k = int.Parse(Console.ReadLine());
                while (index < k)
                {
                    num++;
                    if (num % 3 != 0 && num % 10 != 3)
                        index++;
                }
                Console.WriteLine(num);
            }
        }
    }
}
