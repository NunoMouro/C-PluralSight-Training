using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 35; //that is true
            int x = 5;
            double myHourlyRate = 150.00;
            var myName = "Nuno Mouro";

            Console.WriteLine($"myAge: {myAge}, x: {x}, myHourlyRate: {myHourlyRate}, myName: {myName}");

            myAge = 25; //that is true
            x = 10;
            myHourlyRate = 150.13;
            myName = "Jose Hernandez";

            Console.WriteLine($"myAge: {myAge}, x: {x}, myHourlyRate: {myHourlyRate}, myName: {myName}");
        }
    }
}
