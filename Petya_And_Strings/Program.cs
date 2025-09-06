using System;

namespace Petya_And_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string let1 = Console.ReadLine();
            string let2 = Console.ReadLine();
            let1 = let1.ToLower();
            let2 = let2.ToLower();
            int res = 0;
            for (int i = 0; i < let1.Length; i++)
            {
                if (let1[i] < let2[i])
                {
                    res = -1;
                    break;
                }
                else if (let1[i] > let2[i])
                {
                    res = 1;
                    break;
                }
            }
            Console.WriteLine(res);
        }
    }
}
