using System.IO;
using System.Runtime.Serialization;

namespace Team_Serializer
{
    class Serialize<T> where T : new()
    {
        public static void SerializeItem(string filename, IFormatter formatter, T item)
        {
            FileStream s = new FileStream(filename, FileMode.Create);
            formatter.Serialize(s, item);
            s.Close();
        }
        public static T DeserializeItem(string filename, IFormatter formatter)
        {
            FileStream s = new FileStream(filename, FileMode.Open);
            T item = (T)formatter.Deserialize(s);
            s.Close();
            return item;
        }
    }
}