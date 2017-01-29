using System;

class Rectangle
{
    static void Main()
    {
        int n = 10;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}