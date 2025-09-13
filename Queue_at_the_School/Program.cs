using System;

namespace Queue_at_the_School
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            //string s = Console.ReadLine();
            char[] ch = Console.ReadLine().ToCharArray();
            int n = Int32.Parse(input[0]);
            int t = Int32.Parse(input[1]);
            string res = "";
            int count;
            for (int i = 0; i < n; i += count + 1)
            {
                count = 0;
                if (ch[i] == 'G')
                {
                    res += ch[i];
                    continue;
                }

                t += i;
                for (int j = i; j < t; ++j)
                {
                    //GBGBG t = 2
                    if (ch[j] == 'B' && ch[j + 1] == 'G')
                    {
                        char temp = ch[j];
                        ch[j] = ch[j + 1];
                        ch[j + 1] = temp;
                        count++;
                        //if (ch[j + 1] == 'G')
                        //{
                        //    res += s[j + 1];
                        //    res += s[j];
                        //    count++;  
                        //}
                    }
                }
            }

            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
