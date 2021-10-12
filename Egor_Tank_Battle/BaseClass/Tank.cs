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

        public string Name { get; protected set; }

        public int Ammo { get; protected set; }

        public int Armour { get; protected set; }

        public int Mobility { get; protected set; }

        public static int operator * (Tank firstSide, Tank seconSide)
        {

            int battlePoints = 0;

            battlePoints += firstSide.Ammo > seconSide.Ammo ? 1 : firstSide.Ammo < seconSide.Ammo ? -1 : 0;

            battlePoints += firstSide.Armour > seconSide.Armour ? 1 : firstSide.Armour < seconSide.Armour ? -1 : 0;

            battlePoints += firstSide.Mobility > seconSide.Mobility ? 1 : firstSide.Mobility < seconSide.Mobility ? -1 : 0;

            Console.WriteLine(battlePoints > 0 ? $"Победа за {firstSide.Name}" : battlePoints < 0 ? $"Победа за {seconSide.Name}" : "Ничья");

            return battlePoints;
            
        }


    }
}
