using System;
using System.Collections.Generic;
using System.Linq;

namespace Grouping
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>()
            {
                new Team{NameTeam="Persepilis" , CuntryTeam="Iran"},
                new Team{NameTeam="Barcelona" , CuntryTeam="Espania"},
                new Team{NameTeam="RealMadrid" , CuntryTeam="Espania"},
                new Team{NameTeam="BayernMunich" , CuntryTeam="Germania"},
            };

            var resultgroupby = teams.GroupBy(p => p.CuntryTeam);

            foreach(var cuntrys in resultgroupby)
            {
                Console.WriteLine($"Cuntry = {cuntrys.Key}");

                foreach(var name in cuntrys)
                {
                    Console.WriteLine($"Name = {name.NameTeam}");
                }

                Console.WriteLine("________________________________________________");
            }

            Console.WriteLine("-----------------------Break Tow Metode-----------------------");

            var resultlookup = teams.ToLookup(p => p.CuntryTeam);

            foreach (var cuntrys in resultgroupby)
            {
                Console.WriteLine($"Cuntry = {cuntrys.Key}");

                foreach (var name in cuntrys)
                {
                    Console.WriteLine($"Name = {name.NameTeam}");
                }

                Console.WriteLine("________________________________________________");
            }

            Console.ReadLine();
        }

        public class Team
        {
            public string NameTeam { get; set; }
            public string CuntryTeam { get; set; }
        }
    }
}
