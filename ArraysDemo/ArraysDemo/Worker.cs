using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            Person[] people = new Person[7];
            //people[4] = new Person { Name = "Nuno" };
            //Person person = people[4];
            //Console.WriteLine($"person: { person.Name}");

            //Person secondPerson = people[5];
            //Console.WriteLine($"secondperson: {secondPerson.Name}");
            people[0] = new Person() { Name = "Jonh" };
            people[1] = new Person() { Name = "Paul" };
            people[2] = new Person() { Name = "George" };
            people[3] = new Person() { Name = "Ringo" };
            people[4] = new Person() { Name = "Nuno" };
            people[5] = new Person() { Name = "Kurt" };
            people[6] = new Person() { Name = "Bert" };

            //for (int i = 0; i< people.length; i++)
            //{
            //    console.writeline($"name = {people[i].name}");
            //}

            foreach(Person person in people)
            {
                Console.WriteLine($"Name: {person.Name}");
            }
        }
    }
}
