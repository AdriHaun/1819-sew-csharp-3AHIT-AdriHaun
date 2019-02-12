using System;

namespace Team_Clone
{
    class Person : ICloneable
    {
        public double Age { get; set; }
        public string Name { get; set; }
        public PersonInfo Info;

        public Person(double age, string name, int id)
        {
            Age = age; Name = name; Info = new PersonInfo(id);
        }

        public Person getShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person getDeepCopy()
        {
            Person person = (Person)this.MemberwiseClone();

            person.Info = new PersonInfo(this.Info.PersonId);
            person.Name = string.Copy(Name);
            return person;
        }

        public object Clone()
        {
            return getDeepCopy();
        }

        public override string ToString()
        {
            return (Name + " is " + Age + " years old and has the ID " + Info.PersonId);
        }
    }
}
