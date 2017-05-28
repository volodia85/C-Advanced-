

namespace _04.Count_Symbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountSymbol
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();

            var dict = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                var character = input[i];

                if (!dict.Keys.Contains(character))
                {
                    dict[character] = 0;
                }
                dict[character]++;

            }
            foreach (var w in dict)
            {
                Console.WriteLine($"{w.Key}: {w.Value} time/s");
            }
        }
    }
}
