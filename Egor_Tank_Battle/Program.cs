using System;
using Egor_Tank_Battle.BaseClass;
using Egor_Tank_Battle.Utils;

namespace Egor_Tank_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstTeam = new Team<Tank>(3, "Russians");

            var secondTeam = new Team<Tank>(4, "Germans");

            firstTeam.SetMembers(Creator.CreateTank("T-34"), Creator.CreateTank("T-34"), Creator.CreateTank("T-34"));

            secondTeam.SetMembers(Creator.CreateTank("Panther"), Creator.CreateTank("Panther"), Creator.CreateTank("Panther"));

            Battlefield.Battle(firstTeam, secondTeam);

            Console.ReadKey();
        }
    }
}
