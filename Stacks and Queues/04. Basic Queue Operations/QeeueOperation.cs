using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Basic_Queue_Operations
{
    class QeeueOperation
    {
        static void Main()
        {
            Queue<int> nums = new Queue<int>();

            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var input2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            var amountOfEnqueue = input[0];
            var amountOfDequeue = input[1];
            var checkElement = input[2];

            var queue = new Queue<int>();

            for (int i = 0; i < amountOfEnqueue; i++)
            {
                queue.Enqueue(input2[i]);
            }

            for (int i = 0; i < amountOfDequeue; i++)
            {
                queue.Dequeue();
            }
            if (!queue.Any())
            {
                Console.WriteLine("0");
            }
            else
            {


                if (queue.Contains(checkElement))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
