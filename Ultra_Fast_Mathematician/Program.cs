using System;

namespace Ultra_Fast_Mathematician
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            int len = n1.Length;
            string res = "";
            for (int i = 0; i < len; i++)
            {
                //if (n1[i] != n2[i]) res += '1';
                //else res += '0';
                if (n1[i] != n2[i]) Console.Write(1);
                else Console.Write(0);
            }
            // Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
