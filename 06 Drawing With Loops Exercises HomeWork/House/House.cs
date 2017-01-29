using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int upCounter = (n + 1) / 2;
        int stars = 1;
        if (n % 2 == 0)
        {
            stars = 2;
        }
        for (int i = 0; i < upCounter; i++)
        {
            int line = n / 2 - stars;
            for (int c = 0; c < line + 1; c++)
            {
                Console.Write("-");
            }
            for (int s = 0; s < i + stars; s++)
            {
                Console.Write("*");
            }
            for (int c = 0; c < line + 1; c++)
            {
                Console.Write("-");
            }

            stars++;
            Console.WriteLine();
        }
        int downCounter = n / 2 - 1;
        for (int i = 0; i <= downCounter; i++)
        {
            Console.Write("|");
            for (int s = 0; s < n-2; s++)
                {
                    Console.Write("*");
                }
            Console.WriteLine("|");
        }

    }
}