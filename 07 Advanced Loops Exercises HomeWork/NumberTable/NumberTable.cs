using System;

class NumberTable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                var num = col + row + 1;
                if (num > n)
                {
                    num = -num + 2 * n;
                }

                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}