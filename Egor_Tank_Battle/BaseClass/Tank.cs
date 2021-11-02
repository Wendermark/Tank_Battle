using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Egor_Tank_Battle.Interfaces;

namespace Egor_Tank_Battle.BaseClass
{
    class Tank : ITank
    {
        public Tank(string name, int ammo, int armour, int mobility)
        {
            Name = name;
            Ammo = ammo;
            Armour = armour;
            Mobility = mobility;
        }

        public string Name { get; private set; }

        public int Ammo { get; private set; }

        public int Armour { get; private set; }

        public int Mobility { get; private set; }

        public override string ToString() => $"{Name}\t\t {Ammo}\t {Armour}\t {Mobility}";

        public int CompareTo(ITank other)
        {
            int battlePoints = 0;

            battlePoints += Ammo > other.Ammo ? 1 : Ammo < other.Ammo ? -1 : 0;
            battlePoints += Armour > other.Armour ? 1 : Armour < other.Armour ? -1 : 0;
            battlePoints += Mobility > other.Mobility ? 1 : Mobility < other.Mobility ? -1 : 0;

            Console.WriteLine(battlePoints > 0 ? $"Победа за {Name}" : battlePoints < 0 ? $"Победа за {other.Name}" : "Ничья");

            return battlePoints;
        }
    }
}
