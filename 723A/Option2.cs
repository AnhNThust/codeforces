using System;

public class Option2
{
      static void Main(string[] args)
      {
            // lay ra tung ky tu (kieu string) tu chuoi nhap tu ban phim
            string[] s = Console.ReadLine().Trim().Split(' ');

            // tao mang luu cac bien kieu int co do dai bang voi mang s
            int[] ns = new int[s.Length];

            // bien cac ky tu (kieu string) trong mang s thanh cac bien kieu int trong mang ns
            for (int i = 0; i < s.Length; i++)
                  ns[i] = int.Parse(s[i]);

            // sap xep cac so trong day ns theo chieu tang dan
            Array.Sort(ns);

            // hien thi dau ra cua bai toan
            Console.WriteLine(ns[2] - ns[0]);
            Console.ReadLine();
      }
}
