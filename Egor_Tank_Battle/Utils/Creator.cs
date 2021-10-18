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
        public static Tank CreateTank(string name = "Unknown")
        {
            var rnd = new Random();
            return new Tank(name, rnd.Next(1, 101), rnd.Next(1, 101), rnd.Next(1, 101));
        }
    }
}
