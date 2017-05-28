using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var num = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(input);

            while (queue.Count > 1)
            {
                for (int i = 0; i < num - 1; i++)
                {
                    string reminder = queue.Dequeue();
                    queue.Enqueue(reminder);
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}

