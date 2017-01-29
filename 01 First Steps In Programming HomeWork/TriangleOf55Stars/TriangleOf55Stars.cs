using System;

class TriangleOf55Stars
{
    static void Main()
    {
        for (int i = 0; i <= 9; i++)
        {

            var asteriskPlus = i + 1;
            for (int j = 1; j <= asteriskPlus; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
    }
}