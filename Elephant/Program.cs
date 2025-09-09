using System;

namespace Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Int32.Parse(Console.ReadLine());
            int step = Step(x);
            Console.WriteLine(step);
            Console.ReadLine();
        }

        static int Step(int len)
        {
            return len <= 5 ? 1 : 
                len % 5 == 0 ? len / 5 :
                (len / 5) + 1;
        }
    }
}
