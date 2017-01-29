using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingArray
{
    class ReadingArray
    {
        private static object tokens;

        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] tokens = line.Split(' ');
            //line = line.Replace("  ", " "); 
            // Заменя 2 интервала с 1
            //tokens = line.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            // Премахва Интервал , запетая , точка и запетая
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < tokens.Length; i++)
            {
                if(tokens[i] != "")
                Console.WriteLine(tokens[i]);
            }

        }
    }
}
