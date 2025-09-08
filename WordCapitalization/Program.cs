using System;

namespace WordCapitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string s1 = s.Substring(1);
            //if (s[0] >= 'A' && s[0] <= 'Z')
            if (Char.IsUpper(s[0]))
                Console.WriteLine(s);
            else
            {
                char s0 = (char)(s[0]-32);
                Console.WriteLine($"{s0}{s1}");
            }
        }
    }
}
