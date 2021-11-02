using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Egor_Tank_Battle.BaseClass;

namespace Egor_Tank_Battle.Utils
{
    class Creator
    {
        readonly static Random rnd = new();
        public static Tank CreateTank(string name = "Unknown") => new Tank(name, rnd.Next(1, 101), rnd.Next(1, 101), rnd.Next(1, 101));
    }
}
