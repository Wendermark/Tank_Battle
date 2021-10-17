using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Tank_Battle.BaseClass
{
    class Tank
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

        public static Tank[] CreateTanks( int count, string nameOfTanks = "Unknown tank" )
        {
            var random = new Random();

            Tank[] createdArray = new Tank[count];

            for (int i = 0; i < createdArray.Length; i++)
                createdArray[i] = new Tank(nameOfTanks, random.Next(1, 101), random.Next(1, 101), random.Next(1, 101));

            return createdArray;
        }

        public static int operator * (Tank firstSide, Tank secondSide)
        {
            int battlePoints = 0;

            battlePoints += firstSide.Ammo > secondSide.Ammo ? 1 : firstSide.Ammo < secondSide.Ammo ? -1 : 0;

            battlePoints += firstSide.Armour > secondSide.Armour ? 1 : firstSide.Armour < secondSide.Armour ? -1 : 0;

            battlePoints += firstSide.Mobility > secondSide.Mobility ? 1 : firstSide.Mobility < secondSide.Mobility ? -1 : 0;

            Console.WriteLine(battlePoints > 0 ? $"Победа за {firstSide.Name}" : battlePoints < 0 ? $"Победа за {secondSide.Name}" : "Ничья");

            return battlePoints;
        }
    }
}
