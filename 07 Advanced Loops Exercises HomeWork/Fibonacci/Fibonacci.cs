using System;

class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var f0 = 1;
        var f1 = 1;
        var sum = 0;

        for (int i = 1; i <= n - 1; i++)
        {
            sum = f0 + f1;
            f0 = f1;
            f1 = sum;

        }

        if (n <= 1)
        {
            sum = 1;
        }
        Console.WriteLine(sum);
    }
}