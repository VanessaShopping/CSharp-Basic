using System;

class Cinema
{
    static void Main()
    {
        string projectType = Console.ReadLine().ToLower();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        double price = -1.0;

        if (projectType == "premiere")
        {
            price = 12.00;
        }
        else if (projectType == "normal")
        {
            price = 7.50;
        }
        else if (projectType == "discount")
        {
            price = 5.00;
        }
        Console.WriteLine("{0:f2}", columns * rows * price);
    }
}