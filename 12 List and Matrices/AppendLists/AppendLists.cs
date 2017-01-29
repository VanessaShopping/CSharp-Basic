using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            List<string> lists = Console.ReadLine().Split('|').ToList();
            List<string> result = new List<string>();
            for (int i = lists.Count - 1; i >= 0; i--)
            {
                string[] currentList = lists[i].Split(' ');
                foreach (var item in currentList)
                    if (item != "")
                        result.Add(item);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}