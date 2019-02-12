using System;
using System.Collections;

namespace Team_Serializer
{
    [Serializable]
    class Team : ICloneable
    {
        public ArrayList TeamMembers = new ArrayList();

        public Team() { }

        private Team(ArrayList members)
        {
            foreach (Person person in members)
            {
                TeamMembers.Add(person.Clone());
            }
        }

        public void AddMember(Person member)
        {
            TeamMembers.Add(member);
        }

        public object Clone()
        {
            return new Team(this.TeamMembers);
        }
    }
}