using System;

class InchesToCentimeters
{
    static void Main()
    {
        Console.WriteLine("Convert Inch To Centimeters");
        Console.Write("Enter a number in inches: ");
        var inch = double.Parse(Console.ReadLine());
        var cm = inch * 2.54;
        Console.WriteLine("{0} inches = {1} Centimeters", inch, cm);
    }
}