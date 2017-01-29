using System;

class SquareOfStars
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        for (int j = 2; j < n; j++)
        {
            Console.Write("*");
            var space = n - 2;
            for (int i = 0; i < space; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
        }
        for (int la = 1; la <= n; la++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}