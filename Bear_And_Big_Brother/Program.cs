using System;

namespace Bear_And_Big_Brother
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] wei = input.Split(' ');
            int l = Int32.Parse(wei[0]);
            int b = Int32.Parse(wei[1]);
            int i = 0;
            while(l <= b)
            {
                l *= 3;
                b *= 2;
                i++;
            }
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
