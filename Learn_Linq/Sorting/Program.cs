using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {

            var dataOrderby = GetCourseslist().OrderBy(p => p.Price);
           
            Console.WriteLine("<<------------------Orderby--------------->>");

            foreach(var item in dataOrderby)
            {
                Console.WriteLine($"ID = {item.Id} Name = {item.Name}  Price = {item.Price}");
            }
            //=================================================

            var dataOrbydescending = GetCourseslist().OrderByDescending(p=> p.Price);

            Console.WriteLine("<<------------------Orbydescending--------------->>");

            foreach (var item in dataOrbydescending)
            {
                Console.WriteLine($"ID = {item.Id} Name = {item.Name} Price = {item.Price}");
            }

            var Thenby = GetCourseslist().OrderBy(p=> p.Price).ThenBy(p=> p.Name);

            Console.WriteLine("<<------------------ThenBy--------------->>");

            foreach (var item in Thenby)
            {
                Console.WriteLine($"ID = {item.Id} Name = {item.Name} Price = {item.Price}");
            }

            var ThenbyDecening = GetCourseslist().OrderByDescending(p => p.Price).ThenByDescending(p=> p.Name);

            Console.WriteLine("<<------------------ThenByDecening--------------->>");

            foreach(var item in ThenbyDecening)
            {
                Console.WriteLine($"ID = {item.Id} Name = {item.Name} Price = {item.Price}");
            }
            
            Console.WriteLine("<<------------------Reverse--------------->>");

            foreach(var item in ThenbyDecening.Reverse())
            {
                Console.WriteLine($"ID = {item.Id} Name = {item.Name} Price = {item.Price}");
            }

            Console.ReadLine();
        }


        private static List<Course> GetCourseslist()
        {
            List<Course> courses = new List<Course>()
            {
                new Course{Id=11, Name="C#", Price=10000},
                new Course{Id=2, Name="ASP.NET", Price=20000},
                new Course{Id=3, Name="HTML", Price=5000},
                new Course{Id=4, Name="CSS", Price=3000},
                new Course{Id=5, Name="JS", Price=15000},
                new Course{Id=6, Name="ANGULAR", Price=1000},
                new Course{Id=7, Name="AAGULAR", Price=1000},
            };
            return courses;
        }

        public class Course
        {
            public int Id { get; internal set; }
            public string Name { get; internal set; }
            public int Price { get; internal set; }
        }
    }
}
