using System;
using System.Collections.Generic;
using System.Linq;

namespace Partitioning
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> Number = new List<int> {5,6,8,10,7,2,1,9,9,4,12 };

            Console.WriteLine("--------------------Skip-------------------");
            var numberSkip = Number.Skip(5);
            foreach (var item in numberSkip)
            {
                Console.WriteLine(item+",");
            }

            Console.WriteLine("--------------------SkipWhile-------------------");

            var numberSkipWhile = Number.SkipWhile(p => p < 9);
            foreach(var item in numberSkipWhile)
            {
                Console.WriteLine(item+",");
            }

            Console.WriteLine("--------------------Take-------------------");

            var numberTake=Number.Take(3);
            foreach(var item in numberTake)
            {
                Console.WriteLine(item+",");
            }

            Console.WriteLine("--------------------TakeWhile-------------------");

            var numberTakeWhile = Number.TakeWhile(p => p < 9);
            foreach (var item in numberTakeWhile)
            {
                Console.WriteLine(item+",");
            }

            Console.WriteLine("--------------------TakeWhile-------------------");

            var numberTakeLast = Number.TakeLast(4);
            foreach (var item in numberTakeLast)
            {
                Console.WriteLine(item + ",");
            }

            Console.ReadLine();
        }
    }
}
