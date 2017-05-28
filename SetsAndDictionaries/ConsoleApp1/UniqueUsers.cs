using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var uniqueNames = new HashSet<string>();

            for (int i = 0; i < input; i++)
            {
                var names = Console.ReadLine();

                uniqueNames.Add(names);
            }
            foreach (var uniqueName in uniqueNames)
            {
                Console.WriteLine(uniqueName);
            }
        }
    }
}
