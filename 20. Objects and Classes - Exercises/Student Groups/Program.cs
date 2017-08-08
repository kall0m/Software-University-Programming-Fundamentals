using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Groups
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime RegistrationDate { get; set; }
        }
        
        class Town
        {
            public string Name { get; set; }
            public int SeatsCount { get; set; }
            public List<Student> Students { get; set; }
        }

        class Group
        {
            public Town Town { get; set; }
            public List<Student> Students { get; set; }
        }

        static void Main(string[] args)
        {
            List<Town> towns = ReadTownsAndStudents();
            List<Group> groups = DistributeStudentsIntoGroups(towns);
            PrintGroups(groups);
        }

        static void PrintGroups(List<Group> groups)
        {
            var towns = groups.Select(g => g.Town).Distinct().ToList();

            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");

            foreach (var group in groups.OrderBy(g => g.Town.Name))
            {
                Console.WriteLine($"{group.Town.Name} => {string.Join(", ", group.Students.Select(s => s.Email))}");
            }
        }

        static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach (var town in towns.OrderBy(t => t.Name))
            {
                var students = town.Students.OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email).ToList();

                while (students.Count != 0)
                {
                    var group = new Group();

                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();

                    students = students.Skip(group.Town.SeatsCount).ToList();

                    groups.Add(group);
                }
            }

            return groups;
        }

        static List<Town> ReadTownsAndStudents()
        {
            var towns = new List<Town>();

            var inputLine = Console.ReadLine();

            while(inputLine != "End")
            {
                if (inputLine.Contains("=>"))
                {
                    var townInfo = inputLine.Split('=', '>').Where(x => x != "").ToArray();

                    var townName = townInfo[0].Trim();
                    var seats = townInfo[1].Trim().Split().First();

                    Town town = new Town
                    {
                        Name = townName,
                        SeatsCount = int.Parse(seats),
                        Students = new List<Student>()
                    };

                    towns.Add(town);
                }
                else
                {
                    var studentInfo = inputLine.Split('|');

                    var studentName = studentInfo[0].Trim();
                    var studentEmail = studentInfo[1].Trim();
                    var studentDate = DateTime.ParseExact(studentInfo[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    var student = new Student
                    {
                        Name = studentName,
                        Email = studentEmail,
                        RegistrationDate = studentDate
                    };

                    towns.Last().Students.Add(student);
                }

                inputLine = Console.ReadLine();
            }

            return towns;
        }
    }
}
