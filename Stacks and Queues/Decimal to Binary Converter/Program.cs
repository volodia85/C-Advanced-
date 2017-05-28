using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_Binary_Converter
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var second = 0;
            var myStack = new Stack<int>(input);
            while (myStack.Count > 0)
            {
                var first = myStack.Pop() % 2;
                second = first / 2;
                myStack.Push(second);
            }
            Console.WriteLine(second);
        }
    }
}
