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
                int value = 0;
                int k = int.Parse(Console.ReadLine());
                while (index < k)
                {
                    value++;
                    if (value % 3 != 0 && value % 10 != 3)
                        index++;
                }
                Console.WriteLine(value);
            }
        }
    }
}
