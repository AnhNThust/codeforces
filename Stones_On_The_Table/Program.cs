using System;

namespace Stones_On_The_Table
{
    class Program
    {
        #region Option 1
        //static void Main(string[] args)
        //{
        //    int n = Int32.Parse(Console.ReadLine());
        //    string s = Console.ReadLine();
        //    int k = 0;
        //    for (int i = 0; i < s.Length - 1; ++i)
        //    {
        //        if (s[i] != s[i + 1]) continue;
        //        else k++;
        //    }
        //    Console.WriteLine(k);
        //    Console.ReadLine();
        //}
        #endregion

        #region Option 2
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int len = s.Length - 1;
            string res = $"{s[0]}";
            for (int i = 0; i < len; ++i)
            {
                if (s[i] == s[i + 1]) continue;
                else res += s[i + 1];
            }
            Console.WriteLine(len + 1 - res.Length);
            Console.ReadLine();
        }
        #endregion
    }
}
