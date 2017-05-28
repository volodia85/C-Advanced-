using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = Console.ReadLine().Split(',');

            var hash = new SortedSet<string>();
            

            while (!cars.Contains("END"))
            {
                var direction = cars[0];
                var carNumber = cars[1];

                if (direction == "IN")
                {
                    hash.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    hash.Remove(carNumber);
                }

                cars = Console.ReadLine().Split(',');

            }

            if (hash.Any())
            {
                foreach (var h in hash)
                {
                    Console.WriteLine(h);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}

