using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class StFibonacci
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            var stack = new Stack<long>();
            stack.Push(1);
            stack.Push(1);

            for (int i = 2; i < input; i++)
            {
                long prev = stack.Pop();
                long next = stack.Peek() + prev;
                stack.Push(prev);
                stack.Push(next);
            }
            Console.WriteLine(stack.Peek());

        }
    }
}
