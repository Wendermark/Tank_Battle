using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Tank_Battle.BaseClass
{
    class Team<T> : IEnumerable
    {
        public List<T> Members { get; private set; }
        
        public string Name { get; private set; }

        public int Count { get; private set; }

        public Team(int size, string name = "Unknown team")
        {
            Count = 0;
            Members = new List<T>();
            Name = name;
        }

        public void AddMember(T member)
        {
            if (member is not null && !Members.Contains(member))
                Members.Add(member);
        }

        public void SetMembers(params T[] members)
        {
            if (members is not null)
            {
                Members.Clear();
                Members.AddRange(members);
                Count = members.Length;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (T member in Members)
                yield return member;
        }

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
    }
}
