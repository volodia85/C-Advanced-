using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Reverse_Numbers
{
    public class ReverceNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < input.Count; i++)
            {
                numbers.Push(input[i]);
            }

            for (int i = 0; i < input.Count; i++)
            {
                Console.Write($"{numbers.Pop()} ");
            }
        }
    }
}
