using System;

namespace I_Wanna_Be_The_Guy
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string p = Console.ReadLine();
            string q = Console.ReadLine();
            int id1 = p.IndexOf(' ');
            int id2 = q.IndexOf(' ');
            p = p.Remove(0, id1 + 1);
            q = q.Remove(0, id2 + 1);

            if (p.Contains(n) || q.Contains(n))
                Console.WriteLine("I become the guy.");
            else
                Console.WriteLine("Oh, my keyboard!");
            Console.ReadLine();
        }
    }
}
