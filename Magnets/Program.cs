using System;
using System.Collections.Generic;

namespace Magnets
{
    class Program
    {
        #region Option 1
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            List<string> ls = new List<string>();
            string s;
            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine();
                if (ls.Count > 0 && ls[ls.Count - 1] == s) continue;
                ls.Add(s);
            }
            Console.WriteLine(ls.Count);
            Console.ReadLine();
        }
        #endregion

        #region Option 2
        //static void Main(string[] args)
        //{
        //    int n = Int32.Parse(Console.ReadLine());
        //    Console.WriteLine(GroupCount(n));
        //    Console.ReadLine();
        //}

        //static int GroupCount(int n)
        //{
        //    string s;
        //    string list = "";
        //    if (n <= 1) return n;

        //    for (int i = 0; i < n; i++)
        //    {
        //        s = Console.ReadLine();
        //        if (list.Length > 1 && list[list.Length - 2] == s[s.Length - 1]) continue;
        //        list += $"{s} ";
        //    }

        //    return list.Trim().Split(' ').Length;
        //}
        #endregion
    }
}
