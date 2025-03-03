using System;
using System.Collections.Generic;
using System.Linq;

namespace Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------Aggregate-------------------------------");
            List<string> data = new List<string>() { "Asp.NetCore", "C#", "Angular", "C++", "php" };

            var sep = data.Aggregate((s1, s2) => s1 + "------" + s2);

            Console.WriteLine(sep);

            Console.WriteLine("------------------------------Aggregate---------------------------------");

            List<Languge> languges = new List<Languge>()
            {
                new Languge{Name="Asp.NetCore",Price=1000},
                new Languge{Name="C#",Price=1500},
                new Languge{Name="Angular",Price=1100},
                new Languge{Name="C++",Price=7000},
                new Languge{Name="php",Price=2000},
            };

            string sep2 = languges.Aggregate<Languge, string, string>("Languge Name ="
                , (str, p) => str += p.Name + ","
                , str => str.Substring(0, str.Length - 1));

            Console.WriteLine(sep2);

            Console.WriteLine("--------------------------------Average-------------------------------");

            Console.WriteLine($"Average = {languges.Average(p => p.Price).ToString()}");

            Console.WriteLine("--------------------------------Count-------------------------------");

            Console.WriteLine($"Count = {languges.Count().ToString()}");

            Console.WriteLine("--------------------------------Max-------------------------------");

            Console.WriteLine($"Max = {languges.Max(p => p.Price).ToString()}");

            Console.WriteLine("--------------------------------Min-------------------------------");

            Console.WriteLine($"Min = {languges.Min(p=> p.Price).ToString()}");

            Console.WriteLine("--------------------------------Sum-------------------------------");

            Console.WriteLine($"Sum = {languges.Sum(p=> p.Price).ToString()}");

            Console.ReadLine();
        }
    }

    public class Languge
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
