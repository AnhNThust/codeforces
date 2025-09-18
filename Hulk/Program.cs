using System;

namespace Hulk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i > 1) Console.Write("that ");

                if (i % 2 != 0) Console.Write("I hate ");
                else Console.Write("I love ");
            }
            Console.Write("it");
            Console.ReadLine();
        }
    }
}
