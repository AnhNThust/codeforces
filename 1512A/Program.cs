using System;

namespace _1512A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split(' ');
                int spy = 0;
                for (int j = 0; j < n - 2; j++)
                {
                    if (s[j] != s[j + 1] && s[j + 1] != s[j + 2])
                    {
                        spy = j + 1;
                        break;
                    }
                    else if(s[j] != s[j + 1] && s[j + 1] == s[j + 2])
                    {
                        spy = j;
                        break;
                    }
                    else if (s[j] == s[j + 1] && s[j + 1] != s[j + 2])
                    {
                        spy = j + 2;
                        break;
                    }
                }
                Console.WriteLine(spy + 1);
            }
        }
    }
}
