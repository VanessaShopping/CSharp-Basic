using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Foreach
    {
        static void Main(string[] args)
        {
            var days = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            foreach (var day in days)
                Console.WriteLine(day);
        }
    }
}
