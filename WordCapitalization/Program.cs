using System;

namespace WordCapitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            //if (s[0] >= 'A' && s[0] <= 'Z')
            if (Char.IsUpper(s[0]))
                Console.WriteLine(s);
            else
            {
                s[0] = (char)(s[0] - 32);
                // Console.WriteLine($"{(char)(s[0]-32)}{s.Substring(1)}");
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
