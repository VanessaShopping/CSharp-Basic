using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodedAnswers
{
    class EncodedAnswers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            byte a = 0;
            byte b = 0;
            byte c = 0;
            byte d = 0;
            List<char> letter = new List<char>();
            for (int i = 0; i < n; i++)
            {
                uint numberOfAnswer = uint.Parse(Console.ReadLine());

                if (numberOfAnswer % 4 == 0)
                {
                    a++;
                    letter.Add('a');
                }
                else if (numberOfAnswer % 4 == 1)
                {
                    b++;
                    letter.Add('b');
                }
                else if (numberOfAnswer % 4 == 2)
                {
                    c++;
                    letter.Add('c');
                }
                else
                {
                    d++;
                    letter.Add('d');
                }
            }

            Console.WriteLine(string.Join(" ", letter));
            Console.WriteLine("Answer A: {0}", a);
            Console.WriteLine("Answer B: {0}", b);
            Console.WriteLine("Answer C: {0}", c);
            Console.WriteLine("Answer D: {0}", d);

        }
    }
}
