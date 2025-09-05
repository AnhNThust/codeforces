using System;

namespace Beautiful_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 0, h = 0;
            string[] str = new string[5];
            for (int i = 0; i < 5; i++)
            {
                // nhap chuoi chua cac so nguyen
                str[i] = Console.ReadLine();

                // tach cac so tu chuoi roi gan vao mang
                string[] temp = str[i].Split(' ');
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j] != "1") continue;

                    r = i + 1;
                    h = j + 1;
                }
            }
            Console.WriteLine(Math.Abs(r - 3) + Math.Abs(h - 3));
        }
    }
}
