using System;

namespace Nearly_Lucky_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;
            int len = input.Length;
            for (int i = 0; i < len; ++i)
            {
                if (input[i] != '4' && input[i] != '7') continue;
                else if (count == 0 && i == len - 3) break;
                count++;
            }

            if (count != 4 && count != 7)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");
            Console.ReadLine();
        }
    }
}
