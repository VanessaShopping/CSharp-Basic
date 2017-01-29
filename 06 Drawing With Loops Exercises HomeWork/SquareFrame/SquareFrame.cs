using System;

class SquareFrame
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j >= i; j--)
            {
                Console.Write("+");
            }
            for (int t = 0; t < n - 2; t++)
            {
                Console.Write(" -");
            }
            for (int j = 0; j >= i; j--)
            {
                Console.Write(" +");
            }
            Console.WriteLine();
        }
        for (int i = 1; i < n - 1; i++)
        {
            Console.Write("|");
            for (int k = 0; k < n - 2; k++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" |");
        }
        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j >= i; j--)
            {
                Console.Write("+");
            }
            for (int t = 0; t < n - 2; t++)
            {
                Console.Write(" -");
            }
            for (int j = 0; j >= i; j--)
            {
                Console.Write(" +");
            }
            Console.WriteLine();
        }

    }
}