using System;

namespace _141A
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string all = Console.ReadLine();
            Console.WriteLine(CheckLetters(s1, s2, all));
            Console.ReadLine();
        }

        static string CheckLetters(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length) return "NO";
            string total = s1 + s2;
            int len = total.Length;

            char head = 'A';
            while (head <= 'Z')
            {
                int count1 = 0;
                int count2 = 0;
                for (int i = 0; i < len; i++)
                {
                    if (total[i] == head)
                        count1++;
                    if (s3[i] == head)
                        count2++;
                }
                if (count1 != count2)
                    return "NO";
                head++;
            }
            return "YES";
        }
    }
}
