using System;

namespace _1742A
{
      class Program
      {
            static void Main(string[] args)
            {
                  int t = int.Parse(Console.ReadLine());
                  for (int i = 0; i < t; i++)
                  {
                        string[] s = Console.ReadLine().Trim().Split(' ');
                        int a = int.Parse(s[0]);
                        int b = int.Parse(s[1]);
                        int c = int.Parse(s[2]);
                        if (a + b == c || a + c == b || b + c == a)
                              Console.WriteLine("YES");
                        else
                              Console.WriteLine("NO");
                  }
            }
      }
}
