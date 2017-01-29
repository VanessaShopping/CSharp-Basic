using System;


class RhombusOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int s = n; s > i + 1; s--)
            {
                Console.Write(" ");
            }
            for (int a = 1; a < i + 2; a++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        for (int i = 1; i < n; i++)
        {
            for (int s = 0; s < i; s++)
            {
                Console.Write(" ");
            }
            for (int a = i; a < n; a++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}