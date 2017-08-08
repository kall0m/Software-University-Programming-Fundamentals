using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Grades
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double AverageGrade
            {
                get
                {
                    return Grades.Average();
                }
            }
        }

        static void Main(string[] args)
        {
            Student[] students = ReadStudents().Where(s => s.AverageGrade >= 5.00).OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrade).ToArray();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }
        }

        static Student[] ReadStudents()
        {
            int n = int.Parse(Console.ReadLine());

            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                var studentInfo = Console.ReadLine().Split();

                students[i] = new Student()
                {
                    Name = studentInfo[0],
                    Grades = studentInfo.Skip(1).Take(studentInfo.Length - 1).Select(double.Parse).ToList()
                };
            }

            return students;
        }
    }
}
