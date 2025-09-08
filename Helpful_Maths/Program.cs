using System;

namespace Helpful_Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] numbers = s.Split('+');
            int len = numbers.Length;
            BubbleSort(numbers, len);
            for (int i = 0; i < len; i++)
            {
                if (i == len - 1)
                {
                    Console.Write(numbers[i]);
                    break;
                }
                Console.Write(numbers[i] + '+');

            }
        }

        static void BubbleSort(string[] arr, int n)
        {
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    int a1 = Int32.Parse(arr[j]);
                    int a2 = Int32.Parse(arr[j + 1]);
                    if (a1 <= a2) continue;

                    string temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }

                if (swapped == false)
                    break;
            }
        }
    }
}
