using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _03.Periodic_Table
{
    class Table
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var hash = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                hash.AddRange(input);
            }

            foreach (var h in hash.Distinct().OrderBy(a => a))
            {
                Console.Write(h + " ");
            }
        }
    }
}
