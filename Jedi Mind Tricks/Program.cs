using System;
using System.Collections.Generic;

namespace Jedi_Mind_Tricks
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mates = new Dictionary<string, int>();
            mates.Add("Marcus", 19);
            mates.Add("Kent", 42);

            Console.WriteLine($"Marcus er {mates["Marcus"]}");

            Dictionary<string, bool> characters = new Dictionary<string, bool>()
            {
            { "Luke", true },
            { "Han", false },
            { "Chewbacca", false }
            };

            characters.Remove("Han");

            //I REFUSE TO USE VAR!
            foreach (KeyValuePair<string, bool> pair in characters)
            {
                Console.WriteLine(pair);
                Console.WriteLine(pair.Key);
                Console.WriteLine(pair.Value);
            }

            Console.ReadKey();
        }
    }
}
