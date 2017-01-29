using System;

class MetricConverter
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter input measurement unit: ");
        string imu = Console.ReadLine(); // input measurement unit
        Console.WriteLine("Enter output measurement unit: ");
        string omu = Console.ReadLine(); // output measurement unit
        double result = 0;

        ///
        /// METER
        ///
        if (imu == "m")
        {
            if (omu == "m")
            {
                result = number * 1;
            }
            if (omu == "m")
            {
                result = number;
            }
            if (omu == "mm")
            {
                result = number * 1000;
            }
            if (omu == "cm")
            {
                result = number * 100;
            }
            if (omu == "mi")
            {
                result = number * 0.000621371192;
            }
            if (omu == "in")
            {
                result = number * 39.3700787;
            }
            if (omu == "km")
            {
                result = number * 0.001;
            }
            if (omu == "ft")
            {
                result = number * 3.2808399;
            }
            if (omu == "yd")
            {
                result = number * 1.0936133;
            }
        }

        ///
        /// MILLIMETER
        ///
        if (imu == "mm")
        {
            if (omu == "mm")
            {
                result = number * 1;
            }
            number = number / 1000;
            if (omu == "m")
            {
                result = number * 1;
            }
            if (omu == "cm")
            {
                result = number * 100;
            }
            if (omu == "mi")
            {
                result = number * 0.000621371192;
            }
            if (omu == "in")
            {
                result = number * 39.3700787;
            }
            if (omu == "km")
            {
                result = number * 0.001;
            }
            if (omu == "ft")
            {
                result = number * 3.2808399;
            }
            if (omu == "yd")
            {
                result = number * 1.0936133;
            }
        }

        ///
        /// CENTIMETERS
        ///
        if (imu == "cm")
        {

            if (omu == "cm")
            {
                result = number * 1;
            }
            number = number / 100;
            if (omu == "mm")
            {
                result = number * 1000;
            }
            if (omu == "m")
            {
                result = number * 1;
            }
            if (omu == "mi")
            {
                result = number * 0.000621371192;
            }
            if (omu == "in")
            {
                result = number * 39.3700787;
            }
            if (omu == "km")
            {
                result = number * 0.001;
            }
            if (omu == "ft")
            {
                result = number * 3.2808399;
            }
            if (omu == "yd")
            {
                result = number * 1.0936133;
            }
        }

        ///
        /// MILES
        ///
        if (imu == "mi")
        {

            if (omu == "mi")
            {
                result = number * 1;
            }
            number = number / 0.000621371192;
            if (omu == "mm")
            {
                result = number * 1000;
            }
            if (omu == "cm")
            {
                result = number * 100;
            }
            if (omu == "m")
            {
                result = number * 1;
            }
            if (omu == "in")
            {
                result = number * 39.3700787;
            }
            if (omu == "km")
            {
                result = number * 0.001;
            }
            if (omu == "ft")
            {
                result = number * 3.2808399;
            }
            if (omu == "yd")
            {
                result = number * 1.0936133;
            }
        }

        ///
        /// INCHES
        ///
        if (imu == "in")
        {
            if (omu == "in")
            {
                result = number * 1;
            }
            number = number / 39.3700787;
            if (omu == "mm")
            {
                result = number * 1000;
            }
            if (omu == "cm")
            {
                result = number * 100;
            }
            if (omu == "mi")
            {
                result = number * 0.000621371192;
            }
            if (omu == "m")
            {
                result = number * 1;
            }
            if (omu == "km")
            {
                result = number * 0.001;
            }
            if (omu == "ft")
            {
                result = number * 3.2808399;
            }
            if (omu == "yd")
            {
                result = number * 1.0936133;
            }
        }

        ///
        /// MILEAGE
        ///
        if (imu == "km")
        {
            if (omu == "km")
            {
                result = number * 1;
            }
            number = number / 0.001;
            if (omu == "mm")
            {
                result = number * 1000;
            }
            if (omu == "cm")
            {
                result = number * 100;
            }
            if (omu == "mi")
            {
                result = number * 0.000621371192;
            }
            if (omu == "in")
            {
                result = number * 39.3700787;
            }
            if (omu == "m")
            {
                result = number * 1;
            }
            if (omu == "ft")
            {
                result = number * 3.2808399;
            }
            if (omu == "yd")
            {
                result = number * 1.0936133;
            }
        }

        ///
        /// FEETS
        ///
        if (imu == "ft")
        {
            if (omu == "ft")
            {
                result = number * 1;
            }
            number = number / 3.2808399;
            if (omu == "mm")
            {
                result = number * 1000;
            }
            if (omu == "cm")
            {
                result = number * 100;
            }
            if (omu == "mi")
            {
                result = number * 0.000621371192;
            }
            if (omu == "in")
            {
                result = number * 39.3700787;
            }
            if (omu == "km")
            {
                result = number * 0.001;
            }
            if (omu == "m")
            {
                result = number * 1;
            }
            if (omu == "yd")
            {
                result = number * 1.0936133;
            }
        }

        ///
        /// YARDS
        ///
        if (imu == "yd")
        {
            if (omu == "yd")
            {
                result = number * 1;
            }
            number = number / 1.0936133;
            if (omu == "mm")
            {
                result = number * 1000;
            }
            if (omu == "cm")
            {
                result = number * 100;
            }
            if (omu == "mi")
            {
                result = number * 0.000621371192;
            }
            if (omu == "in")
            {
                result = number * 39.3700787;
            }
            if (omu == "km")
            {
                result = number * 0.001;
            }
            if (omu == "ft")
            {
                result = number * 3.2808399;
            }
            if (omu == "m")
            {
                result = number * 1;
            }
        }

        Console.WriteLine(result);
    }
}