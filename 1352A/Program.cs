using System;
using System.Collections.Generic;

namespace _1352A
{
    class Program
    {
        #region option 1
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string s = Console.ReadLine();
                var parts = new List<string>();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] != '0')
                    parts.Add(s[j] + new string('0', s.Length - j - 1));
                }
                Console.WriteLine(parts.Count);
                Console.WriteLine(string.Join(" ", parts));
            }
        }
	    #endregion
        
    }
}
