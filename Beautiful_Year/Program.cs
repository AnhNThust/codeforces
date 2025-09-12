using System;
using System.Collections.Generic;

namespace Beautiful_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            List<char> nums;
            do
            {
                n++;
                string nextYear = n.ToString();
                nums = new List<char>();
                foreach (char c in nextYear)
                {
                    if (nums.Contains(c)) break;
                    nums.Add(c);
                }
            } while (nums.Count < 4);

            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
