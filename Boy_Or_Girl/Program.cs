using System;

namespace Boy_Or_Girl
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int len = name.Length;
            bool isHave;
            string s = "";
            for (int i = 0; i < len; ++i)
            {
                isHave = false;
                for (int j = 0; j < s.Length; ++j)
                {
                    if (name[i] == s[j])
                    {
                        isHave = true;
                        break;
                    }
                }
                
                if (isHave == false)
                {
                    s += name[i];
                }
            }

            if (s.Length % 2 == 0)
                Console.WriteLine("CHAT WITH HER!");
            else
                Console.WriteLine("IGNORE HIM!");

            Console.ReadLine();
        }
    }
}
