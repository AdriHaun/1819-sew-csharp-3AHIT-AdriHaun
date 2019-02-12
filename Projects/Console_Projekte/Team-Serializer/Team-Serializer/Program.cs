using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Team_Serializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Birni = new Person(16, "Dominik", "Birngruber", 2205);

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Birni);
            stream.Close();

            stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            Person restorePerson = (Person)formatter.Deserialize(stream);
            stream.Close();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Mit binärer Serealisierung:\n");
            Console.ResetColor();
            Console.WriteLine("ID Info :    {0}", restorePerson.Info.PersonId);
            Console.WriteLine("First Name : {0}", restorePerson.FirstName);
            Console.WriteLine("Last Name :  {0}", restorePerson.LastName);

            Serialize<Person>.SerializeItem("MyFile.bin", formatter, Birni);

            Person restorePerson2 = Serialize<Person>.DeserializeItem("MyFile.bin", formatter);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n-------------------------------\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Mit generischer Serealisierung:\n");
            Console.ResetColor();
            Console.WriteLine("ID Info :    {0}", restorePerson2.Info.PersonId);
            Console.WriteLine("First Name : {0}", restorePerson2.FirstName);
            Console.WriteLine("Last Name :  {0}", restorePerson2.LastName);

            Console.ReadLine();
        }
    }
}
