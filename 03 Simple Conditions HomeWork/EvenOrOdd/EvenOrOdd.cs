﻿using System;

class EvenOrOdd
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }
}