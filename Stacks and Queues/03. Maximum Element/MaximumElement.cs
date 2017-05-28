using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Maximum_Element
{
    class MaximumElement
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            var numbers = new Stack<int>();
            var second = new Stack<int>();
            
            for (int i = 0; i < input; i++)
            {
                var input2 = Console.ReadLine().Split().Select(int.Parse).ToList();
                var operation = input2[0];
                
                if (operation.Equals(1))
                {
                    numbers.Push(input2[1]);
                }
                else if (operation.Equals(2))
                {
                    numbers.Pop();
                }
                else if (operation.Equals(3))
                {
                    var max = numbers.Max();
                    second.Push(max);
                }
            }
            foreach (var nums in second.Reverse())
            {
                Console.WriteLine(nums);
            }
        }
    }
}
