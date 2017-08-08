using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_by_Age
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            List<Person> people = ReadPeople();

            PrintPeople(people);
        }

        static List<Person> ReadPeople()
        {
            var input = Console.ReadLine().Split();

            var people = new List<Person>();

            while(input[0] != "End")
            {
                var personName = input[0];
                var personID = input[1];
                var personAge = int.Parse(input[2]);

                people.Add(new Person
                {
                    Name = personName,
                    ID = personID,
                    Age = personAge
                });

                input = Console.ReadLine().Split();
            }

            return people;
        }

        static void PrintPeople(List<Person> people)
        {
            foreach (var person in people.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
