using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Tank_Battle.BaseClass
{
    class Battlefield
    {
        public Tank[] FirstSide { get; private set; }

        public Tank[] SecondSide { get; private set; }

        public Battlefield(Tank [] firstSide, Tank [] secondSide)
        {
            FirstSide = firstSide;

            SecondSide = secondSide;
        }

        public void Battle()
        {
            if (FirstSide.Length != SecondSide.Length)
            {
                Console.WriteLine("Неравные силы строн");
                return;
            }

            for (int i = 0; i < FirstSide.Length; i++)
            {
                if (FirstSide[i] is null || SecondSide[i] is null)
                {
                    Console.WriteLine("Обнаружен танк со значением null");
                    return;
                }
            }

            int warPoints = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Танк \t       Боезапас  Броня  Манёвренность \n");

            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < FirstSide.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"Бой № {(i + 1)} \n");

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"{FirstSide[i]?.Name} \t\t {FirstSide[i]?.Ammo} \t {FirstSide[i]?.Armour} \t {FirstSide[i]?.Mobility}");

                Console.WriteLine($"{SecondSide[i]?.Name} \t {SecondSide[i]?.Ammo} \t {SecondSide[i]?.Armour} \t {SecondSide[i]?.Mobility} \n");

                int result = FirstSide[i] * SecondSide[i];

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"{new string('-', 40)}\n");

                warPoints += result > 0 ? 1 : result < 0 ? -1 : 0;
            }
            Console.WriteLine(warPoints > 0 ? $"Победа за командой {FirstSide.First().Name}" : warPoints < 0 ? $"Победа за командой {SecondSide.First().Name}" : "НИЧЬЯ!"); // !!!
        }

    }
}
