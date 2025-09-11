using System;

namespace Anton_And_Danik
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            int countA = 0;
            for (int i = 0; i < n; ++i)
            {
                if (s[i] == 'D') continue;
                countA++;
            }

            if (countA > (float)n / 2)
                Console.WriteLine("Anton");
            else if (countA < (float)n / 2)
                Console.WriteLine("Danik");
            else
                Console.WriteLine("Friendship");
            Console.ReadLine();
        }
    }
}
