using System;

namespace Team_Serializer
{
    [Serializable]
    class PersonInfo
    {
        public int PersonId { get; set; }
        public PersonInfo(int id)
        {
            this.PersonId = id;
        }
    }
}
