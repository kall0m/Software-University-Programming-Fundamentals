using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor_Group
{
    class Program
    {
        class Student
        {
            public List<string> Comments { get; set; }
            public List<DateTime> Attendances { get; set; }
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            var students = ReadStudents();

            PrintStudents(students);
        }

        static void PrintStudents(SortedDictionary<string, Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.Key);

                Console.WriteLine("Comments:");

                foreach (var comment in student.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");

                foreach (var attendance in student.Value.Attendances)
                {
                    Console.WriteLine($"-- {attendance.ToString("dd/MM/yyyy")}");
                }
            }
        }

        static SortedDictionary<string, Student> ReadStudents()
        {
            var students = new SortedDictionary<string, Student>();

            var dates = Console.ReadLine();

            while(dates != "end of dates")
            {
                var datesInfo = dates.Split().ToList();
                var studentName = datesInfo[0];
                var attendances = new List<DateTime>();
                
                if (datesInfo.Count > 1)
                {
                    attendances = datesInfo[1].Split(',').Select(a => DateTime.ParseExact(a, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();
                }

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new Student()
                    {
                        Attendances = new List<DateTime>(),
                        Name = studentName,
                        Comments = new List<string>()
                    };
                }

                students[studentName].Attendances.AddRange(attendances);

                students[studentName].Attendances = students[studentName].Attendances.OrderBy(a => a).ToList();

                dates = Console.ReadLine();
            }

            var comments = Console.ReadLine();

            while(comments != "end of comments")
            {
                var commentsInfo = comments.Split('-').ToList();
                var studentName = commentsInfo[0];
                var userComments = commentsInfo[1];

                if (students.ContainsKey(studentName))
                {
                    students[studentName].Comments.Add(userComments);
                }

                comments = Console.ReadLine();
            }

            return students;
        }
    }
}
