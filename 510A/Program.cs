using System;

namespace _510A
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    string[] s = Console.ReadLine().Split(' ');
        //    int n = int.Parse(s[0]);
        //    int m = int.Parse(s[1]);
        //    bool isTail = false;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //        {
        //            if (i % 2 != 0)
        //            {
        //                Console.Write("#");
        //            }
        //            else
        //            {
        //                if ((isTail == true && j == m - 1) || (isTail == false && j == 0))
        //                {
        //                    Console.Write("#");
        //                    continue;
        //                }
        //                Console.Write(".");
        //            }
        //        }
        //        if (i % 2 != 0)
        //            isTail = !isTail;
        //        Console.WriteLine();
        //    }

        //    Console.ReadLine();
        //}

        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i % 2 != 0)
                        Console.Write("#");
                    else
                    {
                        if (i % 4 != 0)
                        {
                            if (j == m - 1)
                            {
                                Console.Write("#");
                                continue;
                            }
                            Console.Write(".");
                        }
                        else
                        {
                            if (j == 0)
                            {
                                Console.Write("#");
                                continue;
                            }
                            Console.Write(".");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
