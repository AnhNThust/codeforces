using System;

namespace _427A
{
      class Program
      {
            static void Main(string[] args)
            {
                  int n = int.Parse(Console.ReadLine());
                  string[] s = Console.ReadLine().Trim().Split(' ');
                  int[] ns = new int[n];
                  for (int i = 0; i < n; i++)
                  {
                        ns[i] = int.Parse(s[i]);
                  }

                  int count = 0;
                  int sum = 0;
                  for (int i = 0; i < n; i++)
                  {
                        if (sum > 0)
                              sum += ns[i];
                        else
                        {
                              if (ns[i] > 0)
                                    sum += ns[i];
                              else
                                    count++;
                        }
                  }

                  Console.WriteLine(count);
                  Console.ReadLine();
            }
      }
}
