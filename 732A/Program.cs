using System;

namespace _732A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int k = int.Parse(s[0]);
            int r = int.Parse(s[1]);
            int i = 1;
            while (true)
            {
                int total = k * i;
                if (total % 10 == 0 || total % 10 == r)
                    break;
                i++;
            }
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
