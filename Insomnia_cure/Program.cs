using System;

namespace Insomnia_cure
{
      class Program
      {
            static void Main(string[] args)
            {
                  int[] t = new int[4];
                  for (int i = 0; i < 4; i++)
                        t[i] = int.Parse(Console.ReadLine());

                  int d = int.Parse(Console.ReadLine());
                  int count = 0;
                  for (int i = 1; i <= d; i++)
                  {
                        for (int j = 0; j < 4; j++)
                        {
                              if (i % t[j] != 0) continue;
                              count++;
                              break;
                        }
                  }

                  Console.WriteLine(count);
                  Console.ReadLine();
            }
      }
}
