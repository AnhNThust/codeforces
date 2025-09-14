using System;

namespace Queue_at_the_School
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            char[] ch = Console.ReadLine().ToCharArray();
            int n = Int32.Parse(input[0]);
            int t = Int32.Parse(input[1]);
            int head = 0;
            int tail = n - 1;
            for (int i = 0; i < t; i++)
            {
                if (ch[head] == 'G')
                    head++;

                if (ch[tail] == 'B')
                    tail--;

                if (head >= tail) break;

                for (int j = head; j < tail; j++)
                {
                    //if (ch[j] == 'B')
                    //{
                    //    if (ch[j + 1] == 'G')
                    //    {
                    //        char temp = ch[j];
                    //        ch[j] = ch[j + 1];
                    //        ch[j + 1] = temp;
                    //        j++;
                    //    }
                    //}
                    //else continue;

                    // Cach viet duoi tuong tu nhu cach tren
                    if (ch[j] == 'G') continue;
                        
                    if (ch[j + 1] == 'G')
                    {
                        char temp = ch[j];
                        ch[j] = ch[j + 1];
                        ch[j + 1] = temp;
                        j++;
                    }
                }
            }

            for (int i = 0; i < n; i++)
                Console.Write(ch[i]);
            Console.ReadLine();
        }
    }
}
