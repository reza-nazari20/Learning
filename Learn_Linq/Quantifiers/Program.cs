using System;
using System.Collections.Generic;
using System.Linq;

namespace Quantifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Languge> languges = new List<Languge>()
            {
                new Languge{Name="Asp.NetCore",Price=10000},
                new Languge{Name="C#",Price=1500},
                new Languge{Name="Angular",Price=11000},
                new Languge{Name="C++",Price=70000},
                new Languge{Name="php",Price=2000},
            };

            Console.WriteLine("--------------------------------All-------------------------------");

            var resultAll = languges.All(p => p.Price > 9000);

            Console.WriteLine(resultAll);

            Console.WriteLine("--------------------------------Any-------------------------------");

            var resultAny = languges.Any(p => p.Price > 9000);

            Console.WriteLine(resultAny);

            Console.WriteLine("--------------------------------Contains-------------------------------");

            var resultContains = languges.Where(p => p.Name.Contains("A"));

            foreach(var item in resultContains)
            {
                Console.WriteLine($"Languge = {item.Name}");
            }

            Console.ReadLine();
        }
    }

    public class Languge
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
