using System;

namespace Team_Serializer
{
    [Serializable]
    class Person : ICloneable
    {
        public double Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PersonInfo Info;

        public Person() { }
        public Person(double age, string firstname, string lastname, int id)
        {
            Age = age; FirstName = firstname; LastName = lastname; Info = new PersonInfo(id);
        }

        public Person getShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person getDeepCopy()
        {
            Person person = (Person)this.MemberwiseClone();

            person.Info = new PersonInfo(this.Info.PersonId);
            person.FirstName = string.Copy(FirstName);
            person.LastName = string.Copy(LastName);
            return person;
        }

        public object Clone()
        {
            return getDeepCopy();
        }

        public override string ToString()
        {
            return (FirstName + " " + LastName + " is " + Age + " years old and has the ID " + Info.PersonId);
        }
    }
}
