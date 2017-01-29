using System;

class NumberPyramid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = 1;

        for (int row = 1; row <= n; row++)
        {
           

            for (int col = 1; col <= row; col++)
            {
                Console.Write(num + " ");
                num++;
                if (n < num)
                {
                    break;
                }

            }
            Console.WriteLine();
            if (n < num)
            {
                break;
            }
        }

    }
}