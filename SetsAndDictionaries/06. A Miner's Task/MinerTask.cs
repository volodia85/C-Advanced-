namespace _06.A_Miner_s_Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinerTask
    {
        public static void Main()
        {
            var odd = Console.ReadLine();
            var even = Console.ReadLine();

            var dic = new Dictionary<string, string>();

            while (!odd.Contains("stop"))
            {

                dic[odd] = even;
                //Console.WriteLine("{1} -> {0}",even , odd);
                odd = Console.ReadLine();
                even = Console.ReadLine();

            }
            foreach (var dict in dic)
            {
                Console.WriteLine($"{dict.Key} -> {dict.Value}");
            }
        }
    }
}
