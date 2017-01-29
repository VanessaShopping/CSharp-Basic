using System;

class NumberInRange
{
    static void Main()
    {

        Console.WriteLine("Еnter a number in the range[1...100]: ");

        while (true)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());  
                if (n > 0 && n <= 100)
                {
                    Console.WriteLine("The number is: {0}", n);
                    break;
                }
                Console.WriteLine("Invalid number!");

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}