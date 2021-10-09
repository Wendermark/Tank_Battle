using System;
using Egor_Tank_Battle.BaseClass;

namespace Egor_Tank_Battle
{
    class Program
    {

        static void Battle(Tank[] firstSide, Tank[] seconSide)
        {
            if (firstSide.Length != seconSide.Length)
            {
                Console.WriteLine("Неравные силы строн");
                return;
            }

            int points = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Танк \t       Боезапас  Броня  Манёвренность");
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < firstSide.Length; i++)
            {

                bool result = firstSide[i] * seconSide[i];

                Console.WriteLine(new string('-', 40));

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"Бой № {i.ToString()}");

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"{firstSide[i].Name} \t\t {firstSide[i].Ammo.ToString()} \t {firstSide[i].Armour.ToString()} \t {firstSide[i].Mobility.ToString()}");

                Console.WriteLine($"{seconSide[i].Name} \t {seconSide[i].Ammo.ToString()} \t {seconSide[i].Armour.ToString()} \t {seconSide[i].Mobility.ToString()}");

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine();

                Console.WriteLine(result ? $"Победа за {seconSide[i].Name}" : $"Победа за {firstSide[i].Name}");

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(new string('-', 40));

                Console.WriteLine();

                points += result ? 1 : -1;

            }

            Console.WriteLine(points > 0 ? $"Победа за командой {seconSide[0].Name}" : $"Победа за командой {firstSide[0].Name}");

        }

        static void Main(string[] args)
        {

            var random = new Random();

            Tank[] firstSide = new Tank[5];

            Tank[] secondSide = new Tank[5];

            for (int i = 0; i < firstSide.Length; i++)
            {
                firstSide[i] = new Tank("T-34", (byte)random.Next(1, 256), (byte)random.Next(1, 256), (byte)random.Next(1, 256));

                secondSide[i] = new Tank("Panther", (byte)random.Next(1, 256), (byte)random.Next(1, 256), (byte)random.Next(1, 256));
            }

            Battle(firstSide, secondSide);

            Console.ReadKey();
        }
    }
}
