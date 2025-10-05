using System;
using System.Collections.Generic;
namespace _723A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int[] ns = new int[s.Length];
            for (int i = 0; i < 3; i++)
            {
                  ns[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < 3; i++)
            {
                  for (int j = 0; j < 2; j++)
                  {
                        if (ns[j] > ns[j+1])
                        {
                              int temp = ns[j];
                              ns[j] = ns[j+1];
                              ns[j+1] = temp;
                        }
                  }
            }
            Console.WriteLine(ns[2] - ns[0]);
            Console.ReadLine();
        }
    }
}
