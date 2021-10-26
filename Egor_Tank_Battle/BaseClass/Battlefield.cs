using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Tank_Battle.BaseClass
{
    class Battlefield
    {
        public static void Battle(Team<Tank> firstSide, Team<Tank> secondSide)
        {
            if (firstSide is not null && secondSide is not null)
            {
                int warPoints = 0;

                Console.WriteLine("Танк \t     Боезапас  Броня  Манёвренность \n");

                for (int i = 0; i < (firstSide.Count < secondSide.Count ? firstSide.Count : secondSide.Count); i++)
                {
                    Console.WriteLine($"Бой № {(i + 1)} \n");

                    Console.WriteLine(firstSide[i]);
                    Console.WriteLine(secondSide[i]);

                    int result = firstSide[i].CompareTo(secondSide[i]);

                    Console.WriteLine($"{new string('-', 40)}\n");

                    warPoints += result > 0 ? 1 : result < 0 ? -1 : 0;
                }
                Console.WriteLine(warPoints > 0 ? $"Победа за командой {firstSide.Name}" : warPoints < 0 ? $"Победа за командой {secondSide.Name}" : "НИЧЬЯ!");
            }
        }
    }
}
