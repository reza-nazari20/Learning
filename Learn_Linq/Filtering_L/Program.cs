using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Filtering_L
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = GetCourseslist().Where((c, i) =>
            //{
            //    if (i % 2 == 0)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //);

            //foreach(var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //}

            IList list = new ArrayList();
            list.Add(10);
            list.Add("Test");
            list.Add("Learn");
            list.Add(5);
            list.Add(new Course { Id = 7, Name = "BOOTSTRAP", Price = 5500 });

            var intResult = list.OfType<int>();
            var stringResult=list.OfType<string>();

            Console.ReadLine();
        }


        private static List<Course> GetCourseslist()
        {
            List<Course> courses = new List<Course>()
            {
                new Course{Id=1, Name="C#", Price=10000},
                new Course{Id=2, Name="ASP.NET", Price=20000},
                new Course{Id=3, Name="HTML", Price=5000},
                new Course{Id=4, Name="CSS", Price=3000},
                new Course{Id=5, Name="JS", Price=15000},
                new Course{Id=6, Name="ANGULAR", Price=1000},
            };
            return courses;
        }
    }
}
