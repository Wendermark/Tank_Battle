using System;
using Egor_Tank_Battle.BaseClass;

namespace Egor_Tank_Battle
{
    class Program
    {

        static void Battle(Tank[] firstSide, Tank[] secondSide)
        {

            Console.Clear();

            if (firstSide.Length != secondSide.Length)
            {
                Console.WriteLine("Неравные силы строн");
                return;
            }

            int warPoints = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Танк \t       Боезапас  Броня  Манёвренность");
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < firstSide.Length; i++)
            {

                Console.WriteLine(new string('-', 40));

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"Бой № {(i + 1).ToString()}");

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"{firstSide[i].Name} \t\t {firstSide[i].Ammo.ToString()} \t {firstSide[i].Armour.ToString()} \t {firstSide[i].Mobility.ToString()}");

                Console.WriteLine($"{secondSide[i].Name} \t {secondSide[i].Ammo.ToString()} \t {secondSide[i].Armour.ToString()} \t {secondSide[i].Mobility.ToString()}");

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine();

                //Console.Beep();

                int result = firstSide[i] * secondSide[i];

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(new string('-', 40));

                Console.WriteLine();

                warPoints += result > 0 ? 1 : result < 0 ? -1 : 0;

            }

            Console.WriteLine(warPoints > 0 ? $"Победа за командой {firstSide[0].Name}" : warPoints < 0 ? $"Победа за командой {secondSide[0].Name}" : "НИЧЬЯ!");

        }

        static void Main(string[] args)
        {

            var random = new Random();

            Tank[] firstSide = new Tank[5];

            Tank[] secondSide = new Tank[5];

            for (int i = 0; i < firstSide.Length; i++)
            {
                firstSide[i] = new Tank("T-34", random.Next(1, 101), random.Next(1, 101), random.Next(1, 101));

                secondSide[i] = new Tank("Panther", random.Next(1, 101), random.Next(1, 101), random.Next(1, 101));
            }

            Battle(firstSide, secondSide);

            Console.ReadKey();
        }
    }
}
