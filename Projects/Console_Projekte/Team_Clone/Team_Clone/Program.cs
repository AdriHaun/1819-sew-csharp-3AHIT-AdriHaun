using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Clone
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Hofer = new Person(16, "Dominik Hofer", 1407);
            Person Birni = new Person(16, "Dominik Birngruber", 2205);
            Person Ich = new Person(17, "Adrian Haunschmied", 1501);

            Team Row = new Team();
            Row.AddMember(Hofer);
            Row.AddMember(Birni);
            Row.AddMember(Ich);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Reihe:\n");
            Console.ResetColor();

            foreach (Person p in Row.TeamMembers)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n------------------------------------------------------------\n");
            Console.ResetColor();

            Team Row2 = (Team)Row.Clone();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Reihe (cloned):\n");
            Console.ResetColor();

            foreach (Person p in Row2.TeamMembers)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadLine();
        }
    }
}
