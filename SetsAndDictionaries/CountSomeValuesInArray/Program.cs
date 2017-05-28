using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSomeValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var dict = new SortedDictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {

                var counter = 1;
                if (dict.ContainsKey(input[i]))
                {
                    dict[input[i]]++;
                    counter++;
                }
                else
                {
                    dict.Add(input[i], counter);
                }
            }
            foreach (var dic in dict)
            {
                Console.WriteLine($"{dic.Key} - {dic.Value} times");
            }
        }
    }
}
