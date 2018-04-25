using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Rachel = 20;
            int Stacey = 25;
            int Robin = 35;
            int Jesse = 40;

            if(Rachel > 18)
            {
                Console.WriteLine("Rachel Can Vote");
            }

            if (Rachel >= 21 && Robin >= 21)
            {
                Console.WriteLine("The both can drink");
            } else if (Rachel >= 21 || Robin >= 21) {
                Console.WriteLine("At least one can drink");
            }

        }
    }
}
