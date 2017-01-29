using System;

class MaxNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = int.MaxValue;
        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < sum)
            {
                sum = num;
            }
        }
        Console.WriteLine(sum);
    }
}