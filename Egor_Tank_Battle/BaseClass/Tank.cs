using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Tank_Battle.BaseClass
{
    struct Tank : IEquatable<Tank>
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

        public override int GetHashCode()
        {
            int hashcode = Name.GetHashCode();
            hashcode = 31 * hashcode + Ammo.GetHashCode();
            hashcode = 31 * hashcode + Armour.GetHashCode();
            hashcode = 31 * hashcode + Mobility.GetHashCode();

            return hashcode;
        }

        public bool Equals(Tank another) => Name == another.Name && Ammo == another.Ammo && Armour == another.Armour && Mobility == another.Mobility;

        public override bool Equals(object obj) => Equals((Tank)obj);

        public static int operator * (Tank firstSide, Tank secondSide)
        {
            int battlePoints = 0;

            battlePoints += firstSide.Ammo > secondSide.Ammo ? 1 : firstSide.Ammo < secondSide.Ammo ? -1 : 0;

            battlePoints += firstSide.Armour > secondSide.Armour ? 1 : firstSide.Armour < secondSide.Armour ? -1 : 0;

            battlePoints += firstSide.Mobility > secondSide.Mobility ? 1 : firstSide.Mobility < secondSide.Mobility ? -1 : 0;

            Console.WriteLine(battlePoints > 0 ? $"Победа за {firstSide.Name}" : battlePoints < 0 ? $"Победа за {secondSide.Name}" : "Ничья");

            return battlePoints;
        }

        public override string ToString() => $"{Name}\t\t {Ammo}\t {Armour}\t {Mobility}";
    }
}
