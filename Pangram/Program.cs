using System;

namespace Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string s = Console.ReadLine().ToLower();
            bool isHave = true;
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (s.Contains(c.ToString())) continue;
                isHave = false;
                break;
            }

            if (isHave)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}
