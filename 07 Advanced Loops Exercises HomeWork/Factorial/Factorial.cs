using System;

class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 1;

        for (int i = 1; i <= n; i++)
        {
            sum = sum * i;
        }
        Console.WriteLine(sum);

        // Second Decision

        //var result = 1;
        //do
        //{
        //    result = result * n;
        //    n--;
        //} while (n > 1);
        //Console.WriteLine(result);
    }
}