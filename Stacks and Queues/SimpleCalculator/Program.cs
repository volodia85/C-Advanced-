using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var myStack = new Stack<string>(input.Reverse());

            while (myStack.Count > 1)
            {
                var current = int.Parse(myStack.Pop());
                var element = myStack.Pop();
                var second = int.Parse(myStack.Pop());
                switch (element)
                {
                    case "+":
                        myStack.Push((current + second).ToString());
                        break;
                    case "-":
                        myStack.Push((current - second).ToString());
                        break;
                }
            }
            Console.WriteLine(myStack.Pop());

            
            
        }
    }
}
