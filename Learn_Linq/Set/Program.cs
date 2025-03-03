using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Set
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> date = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "2", "2", "2" };
            List<string> date2 = new List<string>() { "1", "4", "5", "7", "9", "10" };

            Console.WriteLine("<-----------------------------Distinct-------------------------->");

            var dataDistinct = date.Distinct();

            foreach (var item in dataDistinct)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("<-----------------------------Except-------------------------->");

            var dataExept = date.Except(date2);

            foreach (var item in dataExept)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("<-----------------------------Intersect-------------------------->");

            var dataInterset = date.Intersect(date2);

            foreach (var item in dataInterset)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("<-----------------------------Union-------------------------->");

            var dataUnion = date.Union(date2);

            foreach (var item in dataUnion)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("<-----------------------------Concat-------------------------->");

            var dataConcat = date.Concat(date2);

            foreach (var item in dataConcat)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("<-----------------------------NEW-------------------------->");
            Console.WriteLine("<-----------------------------NEW-------------------------->");
            Console.WriteLine("<-----------------------------NEW-------------------------->");

            List<User> users = new List<User>()
            {
                new User{Name="Reza"},
                new User{Name="Souzan"},
                new User{Name="Hana"},
                new User{Name="Reza"},
                new User{Name="Korosh"},
                new User{Name="Ghadem"},
                new User{Name="Mohammad"},
                new User{Name="Dara"},
            };

            List<User> user2 = new List<User>()
            {
                new User{Name="Reza"},
                new User{Name="Souzan"},
                new User{Name="Hana"},
                new User{Name="Reza"},
                new User{Name="Ali"},
            };

            Console.WriteLine("<-----------------------------Distinct---User-------------------------->");

            var userDistinct = users.Distinct(new userComparer());

            foreach (var item in userDistinct)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("<-----------------------------Except---User-------------------------->");

            var userExcept = users.Except(user2, new userComparer());

            foreach (var item in userExcept)
            {
                Console.WriteLine(item.Name);

            }

            Console.WriteLine("<-----------------------------Intersect---User-------------------------->");

            var userIntersect = users.Intersect(user2, new userComparer());
            foreach (var item in userIntersect)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("<-----------------------------Union---User-------------------------->");

            var userUnion = users.Union(user2,new userComparer());
            foreach(var item in userUnion)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("<-----------------------------Concat---User-------------------------->");

            var userConcat = users.Concat(user2);
            foreach (var item in userConcat)
            {
                Console.WriteLine(item.Name);
            }


            Console.ReadLine();
        }
    }

    public class User
    {
        public string Name { get; set; }
    }

    public class userComparer : IEqualityComparer<User>
    {
        public bool Equals([AllowNull] User x, [AllowNull] User y)
        {
            if (x.Name == y.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode([DisallowNull] User obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
