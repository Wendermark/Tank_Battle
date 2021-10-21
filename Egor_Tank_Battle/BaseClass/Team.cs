using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Tank_Battle.BaseClass
{
    class Team<T> : IEquatable<Team<T>>
    {
        public T[] Members { get; private set; }
        
        public string Name { get; private set; }

        public int Count { get; private set; }

        public int Length { get; private set; }

        public Team(int size, string name = "Unknown team")
        {
            Count = 0;
            Members = size > 0 ? new T[size] : new T[1];
            Length = Members.Length;
            Name = name;
        }

        public void AddMember(T member)
        {
            if (member is null)
                return;

            if (Count.Equals(Length))
            {
                T[] newArray = new T[Count * 2];

                for (int i = 0; i < Count; i++)
                    newArray[i] = Members[i];

                newArray[Count++] = member;

                Members = newArray;

                Length = newArray.Length;

                Console.WriteLine("Место в массиве закончилось, он был увеличен в 2 раза");
            }
            else
                Members[Count++] = member;
        }

        public void SetMembers(params T[] members)
        {
            if (members is null)
                return;

            Members = members is null ? Members : members;
            Count = Members.Length;
        }

        public bool Equals(Team<T> another)
        {
            if (another is null)
                return false;

            if (Count != another.Count)
                return false;

            for (int i = 0; i < Count; i++)
            {
                if (!Members[i].Equals(another[i]))
                    return false;
            }
            return true;
        }

        public override bool Equals(object obj) => Equals((Team<T>)obj);

        public T this[int index]
        {
            get => (index < Count && Count >= 0) ? Members[index] : default; 
            
            set
            {
                if (index < Count && index >= 0)
                    Members[index] = value;
                else
                    Console.WriteLine("Index out of bounds");
            }

        }

        public override int GetHashCode()
        {
            int hashcode = Members.GetHashCode();
            hashcode = 31 * hashcode + Length.GetHashCode();
            hashcode = 31 * hashcode + Count.GetHashCode();

            return hashcode;
        }
    }
}
