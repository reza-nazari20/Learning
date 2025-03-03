using System;
using System.Collections.Generic;
using System.Linq;

namespace Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Data = new List<int>() { 1,7,8,15,14};
            List<int> Data2 = new List<int>() { 1,7,8,14};

            var dataEqual = Data.SequenceEqual(Data2);
            Console.WriteLine(dataEqual);

            Console.ReadLine();
        }
    }
}
