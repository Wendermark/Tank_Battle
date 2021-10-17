using System;
using Egor_Tank_Battle.BaseClass;

namespace Egor_Tank_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank[] firstSide = Tank.CreateTanks(5, "T-34");

            Tank[] secondSide = Tank.CreateTanks(5, "Panther");

            var battlefield = new Battlefield(firstSide, secondSide);

            battlefield.Battle();

            Console.ReadKey();
        }
    }
}
