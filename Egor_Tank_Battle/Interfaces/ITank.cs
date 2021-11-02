using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Tank_Battle.Interfaces
{
    interface ITank : IComparable<ITank>
    {
        public string Name { get; }

        public int Ammo { get; }

        public int Armour { get; }

        public int Mobility { get; }
    }
}
