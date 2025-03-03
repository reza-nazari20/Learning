using System;
using System.Collections.Generic;
using System.Linq;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray =
            {
                new Student{Name="Reza"},
                new Student{Name="Ahmad"},
                new Student{Name="Messi"},
                new Student{Name="Nonaldo"},
            };

            var enumerable = studentArray.AsEnumerable();
            var queryable = studentArray.AsQueryable();
            var enumerablecast = studentArray.Cast<Student>();
            var toarray = enumerable.ToArray();
            toarray.ToList();

            List<Student> students = new List<Student>()
            {
                new Student{Id=1,Name="Abass"},
                new Student{Id=2,Name="shahin"},
                new Student{Id=3,Name="Arezoo"},
                new Student{Id=4,Name="Aana"},
            };

            IDictionary<int, Student> keyValues = students.ToDictionary<Student, int>(s => s.Id);

            foreach (var key in keyValues.Keys)
            {
                Console.WriteLine("Key: {0}, Value: {1}", key, (keyValues[key] as Student).Name);
            }

            Console.ReadLine();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
