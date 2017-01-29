using System;

class TriangleOfDollars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int d = 0; d <= i; d++)
            {
                Console.Write("$ ");
            }
            Console.WriteLine();
        }
    }
}