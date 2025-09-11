using System;
namespace Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();

            string result = CheckReverse(s, t);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static string CheckReverse(string s, string t)
        {
            int lenS = s.Length;
            int lenT = t.Length;

            if (lenS != lenT) return "NO";
            
            for (int i = 0; i < lenS; ++i)
            {
                if (s[i] == t[lenS - i - 1]) continue;
                return "NO";
            }

            return "YES";
        }
    }
}
