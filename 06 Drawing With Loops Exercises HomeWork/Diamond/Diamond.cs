using System;

class Diamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int topCount = 1;
        int stars = 1 + (n + 1) % 2;
        int midLine = 1;
        int line = (n - midLine - stars) / 2;
        if (n % 2 == 0)
        {
            midLine = 2;
        }
        if (n == 1 || n == 2)
        {
            topCount = 0;
        }
        // Top Part - First Line
        for (int i = 0; i < 1; i++)
        {
            for (int l = 0; l < (n - stars) / 2; l++)
            {
                Console.Write("-");
            }
            for (int s = 0; s < stars; s++)
            {
                Console.Write("*");
            }
            for (int l = 0; l < (n - stars) / 2; l++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        // Top Part - Without First Line
        for (int i = 0; i < (n - stars) / 2; i++)
        {
            Console.Write(new string('-', line));
            Console.Write("*");
            Console.Write(new string('-', midLine));
            Console.Write("*");
            Console.Write(new string('-', line));

            Console.WriteLine();
            midLine = midLine + 2;
            line = line - 1;
        }
        midLine = midLine - 2;
        line = line + 2;
        // Down Part - Without Last Line
        int downCount = (n / 2);
        if (n % 2 == 0)
        {
            downCount = (n / 2) - 1;
        }

        for (int i = 0; i < downCount - 1; i++)
        {
            midLine = midLine - 2;
            Console.Write(new string('-', line));
            Console.Write("*");
            for (int m = 0; m < midLine; m++)
            {
                Console.Write("-");
            }
            Console.Write("*");
            Console.Write(new string('-', line));
            Console.WriteLine();

            line = line + 1;
        }
        // Down Part - Last Line
        for (int i = 0; i < topCount; i++)
        {
            for (int l = 0; l < (n - stars) / 2; l++)
            {
                Console.Write("-");
            }
            for (int s = 0; s < stars; s++)
            {
                Console.Write("*");
            }
            for (int l = 0; l < (n - stars) / 2; l++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}