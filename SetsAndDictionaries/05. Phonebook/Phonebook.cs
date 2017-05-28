namespace _05.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var dict = new Dictionary<String, String>();

            while (!input.Contains("search"))
            {

                if (dict.Keys.Contains(input[1]))
                {
                    dict[input[0]] = input[1];
                }
                else
                {
                    dict.Add(input[0], input[1]);
                }

                input = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            }
            
            var search = Console.ReadLine();
            while (!search.Contains("stop"))
            {
                if (search.Contains("stop"))
                {
                break;

                }
                else
                {
                    if (dict.ContainsKey(search))
                    {
                        Console.WriteLine("{0} -> {1}", search, string.Join(", ", dict[search]));
                    }
                    else
                    {
                        Console.WriteLine($"Contact {search} does not exist.");
                    }
                    search = Console.ReadLine();
                }
            }
        }
    }
}
