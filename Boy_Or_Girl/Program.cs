using System;
using System.Collections.Generic;

namespace Boy_Or_Girl
{
    class Program
    {
        #region Option 2
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine(BoGTest(name));
            Console.ReadLine();
        }
        #endregion

        #region Option 1
        //static void Main(string[] args)
        //{
        //    string name = Console.ReadLine();

        //    int len = name.Length;
        //    bool isHave;
        //    string s = "";
        //    for (int i = 0; i < len; ++i)
        //    {
        //        isHave = false;
        //        for (int j = 0; j < s.Length; ++j)
        //        {
        //            if (name[i] == s[j])
        //            {
        //                isHave = true;
        //                break;
        //            }
        //        }

        //        if (isHave == false)
        //        {
        //            s += name[i];
        //        }
        //    }

        //    if (s.Length % 2 == 0)
        //        Console.WriteLine("CHAT WITH HER!");
        //    else
        //        Console.WriteLine("IGNORE HIM!");

        //    Console.ReadLine();
        //}
        #endregion

        /// <summary>
        /// Ham se tach cac ky tu rieng biet (khong trung lap) ra 1 List </br>
        /// Neu do dai cua List la chan -> in ra "CHAT WITH HER!" <br/>
        /// Neu do dai cua List la le -> in ra "IGNORE HIM!" <br/>
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static string BoGTest(string input)
        {
            int len = input.Length;
            List<char> chs = new List<char>();
            for (int i = 0; i < len; ++i)
            {
                if (chs.Contains(input[i])) continue;
                chs.Add(input[i]);
            }
            return chs.Count % 2 == 0 ? "CHAT WITH HER!" : "IGNORE HIM!";
        }
    }
}
