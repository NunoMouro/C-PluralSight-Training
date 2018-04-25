using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            //List<Person> people = new List<Person>();

            //Person jonh = new Person() { Name = "John" };
            //people.Add(jonh);
            //people.Add(new Person() { Name = "Paul" });
            //people.Add(new Person() { Name = "George" });
            //people.Add(new Person() { Name = "Ringo" });
            //people.Add(new Person() { Name = "Nuno" });

            //foreach(Person person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}");
            //}

            Dictionary<string, Person> dict = new Dictionary<string, Person>();
            Person george = new Person() { Name = "George Washington", Age = 67 };
            string key = "George";
            dict.Add(key, george);
            dict.Add("john", new Person() { Name = "John Adams", Age=80 });
            dict.Add("thom", new Person() { Name = "Thomas Jefferson", Age = 50 });
            dict.Add("james", new Person()  { Name = "James Madison", Age = 30 });

            Person secondPresident = dict["john"];
            Console.WriteLine($"The second president was: {secondPresident.Name}");
        }
    }


}
