using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            Console.WriteLine($"X is equal to {x}");

            List<string> authors = null;
            int? count = authors?.Count;

            string message = count == null
                ? "count is null"
                : "count is not null";
            Console.WriteLine(message);

            int howMany = authors?.Count ?? 0;
            Console.WriteLine($"howMany: {howMany}");

            authors = new List<string>()
            {
                "author one",
                "author two"
            };

            howMany = authors?.Count ?? 0;
            Console.WriteLine($"How many = {howMany}");

            int a = 10;
            int b = 20;
            int bigger = a > b ? a : b;
            Console.WriteLine(bigger);
        }
    }
}
