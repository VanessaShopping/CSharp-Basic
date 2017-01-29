using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithNumbers
{
    class OperationsWithNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            int result = 0;
            string evenOdd = "odd";

            if (c == '+')
            {
                result = a + b;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                Console.WriteLine($"{a} {c} {b} = {result} - {evenOdd}");
            }
            else if (c == '-')
            {
                result = a - b;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                Console.WriteLine($"{a} {c} {b} = {result} - {evenOdd}");
            }
            else if (c == '*')
            {
                result = a * b;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                Console.WriteLine($"{a} {c} {b} = {result} - {evenOdd}");
            }

            double divideResult = 0.0;
            if (c == '/' && a != 0 && b != 0)
            {
                divideResult = (double)a / b;
                Console.WriteLine($"{a} / {b} = {divideResult:F2}");
            }
            else if (c == '%' && a != 0 && b != 0)
            {
                divideResult = a % b;
                Console.WriteLine($"{a} % {b} = {divideResult}");
            }
            else if (a == 0 || b == 0)
                Console.WriteLine($"Cannot divide {a} by zero");
        }
    }
}

