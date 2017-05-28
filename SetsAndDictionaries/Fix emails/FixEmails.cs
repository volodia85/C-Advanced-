using System.CodeDom;
using System.IO;

namespace Fix_emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FixEmails
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var email = Console.ReadLine();

            var dict = new Dictionary<string, string>();
            
            
            

            while (!name.Equals("stop"))
            {
                var ends = email.Split(new char[] { '.' });
                var end = ends[1];
                if (!end.Equals("uk") && !end.Equals("us"))
                {
                    dict[name] = email;
                }
                
                    name = Console.ReadLine();
                    email = Console.ReadLine();
                
            }
            foreach (var dic in dict)
            {
                Console.WriteLine("{0} -> {1}", dic.Key, dic.Value);
            }
        }
    }
}
