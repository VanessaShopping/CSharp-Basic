using System;

class ChristmasTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        n += 1;

        int asterisk = 1;
        int space = 1;
        int sLine = 1;

        for (int i = 0; i < n; i++)
        {
            for (int s = 0; s < (n - asterisk); s++)
            {
                Console.Write(" ");
            }
            for (int a = n; a > n - i; a--)
            {
                Console.Write("*");
            }
            for (int s = 0; s < sLine; s++)
            {
                Console.Write(" ");
            }
            for (int l = 0; l < sLine; l++)
            {
                Console.Write("|");
            }
            for (int s = 0; s < sLine; s++)
            {
                Console.Write(" ");
            }
            for (int a = n - 1; a >= n - i; a--)
            {
                Console.Write("*");
            }
            asterisk++;
            space--;
            Console.WriteLine();
        }
    }
}
