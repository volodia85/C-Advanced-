using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Sets_Of_Elements
{
    class Elements
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var first = input[0];
            var second = input[1];

            var firstSet = new List<int>();
            var secondSet = new List<int>();

            var shortest = 0;

            for (int i = 0; i < first; i++)
            {
                var reader = int.Parse(Console.ReadLine());

                firstSet.Add(reader);
            }
            for (int i = 0; i < second; i++)
            {
                var reader = int.Parse(Console.ReadLine());

                secondSet.Add(reader);
            }

            var repeat = from x in firstSet
                         where secondSet.Contains(x)
                         select x;

            foreach (int rep in repeat)
            {
                Console.Write(rep + " ");
            }
        }
    }
}
