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

            Console.WriteLine("ID Info : {0}", restorePerson.Info.PersonId);
            Console.WriteLine("First Name : {0}", restorePerson.FirstName);
            Console.WriteLine("Last Name : {0}", restorePerson.LastName);
            Console.ReadLine();
        }
    }
}
