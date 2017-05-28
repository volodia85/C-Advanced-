using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Basic_Stack_Operations
{
    public class BasicStack
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var input2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            var amountPush = input[0];
            var amountPop = input[1];
            var checkElement = input[2];

            var stack = new Stack<int>();

            for (int i = 0; i < amountPush; i++)
            {
                stack.Push(input2[i]);
            }

            for (int i = 0; i < amountPop; i++)
            {
                stack.Pop();
            }

            if (!stack.Any())
            {
                Console.WriteLine("0");
            }
            else
            {
                
                if (stack.Contains(checkElement))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
