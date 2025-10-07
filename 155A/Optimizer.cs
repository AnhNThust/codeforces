using System;

public class Optimizer
{
	static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ');
        int count = 0;
        int min = int.Parse(s[0]);
        int max = min;
        for (int i = 1; i < n; i++)
        {
            int t = int.Parse(s[i]);
            if (t >= min && t <= max) continue;
            count++;
            if (t < min)
                min = t;
            else if (t > max)
                max = t;
        }
        Console.WriteLine(count);
        Console.ReadLine();
    }
}
