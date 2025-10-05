using System;
using System.Collections.Generic;
namespace _723A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                        {
                              if (s[i] > s[i + 1])
                        {
                              string temp = s[i];
                              s[i] = s[i+1];
                              s[i+1] = temp;
                        }
                        }
            }
        }
    }
}
