using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Copy
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(23, "Jeff", 1);
            Person person2 = person1.getShallowCopy();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ShallowClone: \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Person 1: " + person1.ToString());
            Console.WriteLine("Person 2: " + person2.ToString());

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nChanging ID of Person 2 to 5 ...\n");
            Console.ForegroundColor = ConsoleColor.White;

            person2.Info.PersonId = 5;

            Console.WriteLine("Person 1: " + person1.ToString());
            Console.WriteLine("Person 2: " + person2.ToString());

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n--------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            person1 = new Person(23, "Jeff", 1);
            person2 = (Person)person1.Clone();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("DeepClone: \n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Person 1: " + person1.ToString());
            Console.WriteLine("Person 2: " + person2.ToString());

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nChanging ID of Person 2 to 5 ...\n");
            Console.ForegroundColor = ConsoleColor.White;

            person2.Info.PersonId = 5;

            Console.WriteLine("Person 1: " + person1.ToString());
            Console.WriteLine("Person 2: " + person2.ToString());

            Console.ReadLine();
        }
    }
}
