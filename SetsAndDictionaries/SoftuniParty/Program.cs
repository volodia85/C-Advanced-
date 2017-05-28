using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var reservations = new SortedSet<string>();

            while (input != "PARTY")
            {
                if (input.Length == 8)
                {
                    reservations.Add(input);
                }

                input = Console.ReadLine();
            }
            while (input != "END")
            {
                if (reservations.Contains(input))
                {
                    reservations.Remove(input);
                }
                input = Console.ReadLine();
            }
            if (reservations.Any())
            {
                Console.WriteLine(reservations.Count);
                foreach (var res in reservations)
                {
                    Console.WriteLine(res);
                }
            }
        }
    }
}
