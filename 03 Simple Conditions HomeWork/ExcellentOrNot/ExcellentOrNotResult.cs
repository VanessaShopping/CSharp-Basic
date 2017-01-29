using System;

class ExcellentOrNotResult
{
    static void Main(string[] args)
    {
        double number = double.Parse(Console.ReadLine());
        if (number >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}