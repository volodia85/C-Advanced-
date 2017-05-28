using System;
using System.Collections.Generic;
using System.Linq;

namespace __Balanced_Parentheses
{
    class BalancedParentheses
    {
        static void Main()
        {
            var input = Console.ReadLine().ToCharArray();

            var myStack = new Stack<char>();
            var myQueue = new Queue<char>();
            var mystack2 = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                myStack.Push(input[i]);
                myQueue.Enqueue(input[i]);
                mystack2.Push(input[i]);

            }
            var j = input.Length -1;
            var counter = 0;
            for (int i = 0; i < input.Length / 2; i++,j--)
            {
                counter++;
                var first = myStack.Last();
                var second = myQueue.Last();

                if (myStack.Last() == '{' && myQueue.Last() == '}' ||
                    myStack.Last() == '(' && myQueue.Last() == ')' || 
                    myStack.Last() == '[' && myQueue.Last() == ']')
                {
                    myStack.Pop();
                    myQueue.Dequeue();
                    if (counter == input.Length / 2)
                    {
                        Console.WriteLine("YES");
                        break;
                    }
                }
                
                else
                {
                    Console.WriteLine("NO");
                    break;
                }
            }
        }
    }
}
