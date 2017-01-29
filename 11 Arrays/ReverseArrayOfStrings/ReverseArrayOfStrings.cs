using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            for (int i = 0; i < str.Length / 2; i++)
            {
                var old = str[i];
                str[i] = str[str.Length - i - 1];
                str[str.Length - i - 1] = old;
            }


            foreach (var item in str)
            {
                Console.WriteLine("foreach " + item);
            }


            string results = string.Join(" ", str);
            Console.WriteLine("string.Join " + results);


            string[] result = str.Reverse().ToArray();
            Console.WriteLine("Reverse ToArray " + string.Join(" ", str));


            // Некадърен код (индийски)
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').Reverse()));
        }
    }
}
