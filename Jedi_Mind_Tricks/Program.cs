using System;
using System.Collections.Generic;
using System.Linq;

namespace Jedi_Mind_Tricks
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>();
            people.Add("Jakob", 31);
            people.Add("Malene", 29);

            people ["Brynja"] = 4;

            people["mebbebebby"] = 0;

            var jakob = people.First();
            Console.WriteLine(jakob);

            people.Remove("mebbebebby");

            foreach (KeyValuePair<string, int> entry in people)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    entry.Key, entry.Value);
            }
        }
    }
}
