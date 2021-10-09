using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Tank_Battle.BaseClass
{
    class Tank
    {

        public Tank(string name, byte ammo, byte armour, byte mobility)
        {
            Name = name;
            Ammo = ammo;
            Armour = armour;
            Mobility = mobility;
        }

        public string Name { get; protected set; }

        public byte Ammo { get; protected set; }

        public byte Armour { get; protected set; }

        public byte Mobility { get; protected set; }

        public static bool operator * (Tank first, Tank second)
        {

            int points = 0;

            points += first.Ammo > second.Ammo ? 1 : -1;

            points += first.Armour > second.Armour ? 1 : -1;

            points += first.Mobility > second.Mobility ? 1 : -1;

            return points > 0;
            
        }


    }
}
