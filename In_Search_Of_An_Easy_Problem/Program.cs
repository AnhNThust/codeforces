using System;

namespace In_Search_Of_An_Easy_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string nums = Console.ReadLine();
            Console.WriteLine(CheckProblem(nums));
            Console.ReadLine();
        }

        static string CheckProblem(string input)
        {
            return input.IndexOf("1") >= 0 ? "HARD" : "EASY"; 
        }
    }
}
