using System;

namespace Soldier_And_Bananas
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int k = Int32.Parse(numbers[0]); // price per one
            int n = Int32.Parse(numbers[1]); // money now
            int w = Int32.Parse(numbers[2]); // number bananas

            Console.WriteLine(MoneyNeed(k, n, w));
            Console.ReadLine();
        }

        static int MoneyNeed(int k, int n, int w)
        {
            int totalMoney = k * (1 + w) * w / 2;
            int moneyNeed = totalMoney - n;
            return moneyNeed <= 0 ? 0 : moneyNeed;
        }
    }
}
