using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int line = (n - 1) / 2 - 1;


        for (int i = 0; i < 1; i++)
        {
            for (int a = 0; a < n * 2; a++)
            {
                Console.Write("*");
            }
            for (int s = 0; s < n; s++)
            {
                Console.Write(" ");
            }
            for (int x = 0; x < n * 2; x++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < n - 2; i++)
        {
            for (int a = 0; a < 1; a++)
            {
                Console.Write("*");
            }
            for (int c = 0; c < ((n * 2) - 2); c++)
            {
                Console.Write("/");
            }
            for (int x = 0; x < 1; x++)
            {
                Console.Write("*");
            }
            if (i == line)
            {
                for (int w = 0; w < n; w++)
                {
                    Console.Write("|");
                }
            }
            else if (i != line)
            {
                for (int s = 0; s < n; s++)
                {
                    Console.Write(" ");
                }
            }

            for (int j = 0; j < 1; j++)
            {
                Console.Write("*");
            }
            for (int k = 0; k < ((n * 2) - 2); k++)
            {
                Console.Write("/");
            }
            for (int o = 0; o < 1; o++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < 1; i++)
        {
            for (int a = 0; a < n * 2; a++)
            {
                Console.Write("*");
            }
            for (int s = 0; s < n; s++)
            {
                Console.Write(" ");
            }
            for (int x = 0; x < n * 2; x++)
            {
                Console.Write("*");
            }
        }
    }
}