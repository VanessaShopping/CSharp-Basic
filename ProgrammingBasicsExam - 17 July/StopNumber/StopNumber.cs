using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopNumber
{
    class StopNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            List<string> number = new List<string>();


            for (int i = m; i >= n; i--)
            {

                if (i == s && i % 2 == 0 && i % 3 == 0)
                    return;

                if (i % 2 == 0 && i % 3 == 0)
                    Console.Write(i + " ");

            }
        }
    }
}
