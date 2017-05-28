using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _05.Sequence_With_Queue
{
    class SequenceQueue
    {
        static void Main()
        {
            var n = long.Parse(Console.ReadLine());

            var nums = new List<long>();
            var queue = new Queue<long>();
            var counter = 1;
            
            queue.Enqueue(n);
            nums.Add(n);
            while (nums.Count < 50)
            {
                long current = queue.Dequeue();
                long first = current + 1;
                long second = (current * 2) + 1;
                long third = current + 2;
               
                queue.Enqueue(first);
                queue.Enqueue(second);
                queue.Enqueue(third);

                nums.Add(first);
                nums.Add(second);
                nums.Add(third);
                counter++;
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
