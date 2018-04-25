using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee tony = new Employee();
            tony.Income = 150000;
            tony.YearsofService = 8;
            tony.SetRating(Employee.Rating.excellent);
            tony.CalculateRaise();
        }
    }

    public class Employee
    {
        public enum Rating
        {
            poor,
            good,
            excellent
        }

        private Rating rating;

        public double Income { get; set; }
        public int YearsofService { get; set; }
        public void SetRating(Rating rating)
        {
            this.rating = rating;
        }

        public void CalculateRaise()
        {
            double baseRaise = Income * 0.95;
            double bonus = YearsofService * 1000;
            Income += baseRaise + bonus;

            switch (rating)
            {
                case Rating.poor:
                    Income -= YearsofService * 2000;
                    break;
                case Rating.good:
                    break;
                case Rating.excellent:
                    Income += YearsofService * 500;
                    break;
            }

            Console.WriteLine($"New income is {Income}");
        }
    }
}
