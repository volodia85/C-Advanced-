using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Reverse_Numbers
{
    public class ReverceNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToList();

            Stack<char> numbers = new Stack<char>();

            for (int i = 0; i < input.Count; i++)
            {
                numbers.Push(input[i]);
            }

            for (int i = 0; i < input.Count; i++)
            {
                Console.Write($"{numbers.Pop()}");
            }
        }
    }
}
