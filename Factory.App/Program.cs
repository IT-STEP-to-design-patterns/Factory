using System;
using Factory.Lib;
using Factory.Lib.Archer;
using Factory.Lib.Barbarian;
using Factory.Lib.Base;
using Factory.Lib.Mage;

namespace Factory.App
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Класс героя:");
            Console.WriteLine("1. Маг");
            Console.WriteLine("2. Варвар");
            Console.WriteLine("3. Лучник");
            var selectHero = Console.ReadLine();
            Console.WriteLine("Раса героя:");
            Console.WriteLine("1. Человек");
            Console.WriteLine("2. Орк");
            var selectRace = Console.ReadLine();

            var player = CreateHero(selectHero, selectRace);
            var enemy = CreateHero(selectHero, selectRace);

            ShowHero(player);
            ShowHero(enemy);
            player?.Attack(enemy);
            enemy?.Attack(player);
            ShowHero(player);
            ShowHero(enemy);
        }

        private static void ShowHero(Hero hero)
        {
            Console.ForegroundColor = hero switch
            {
                IHuman => ConsoleColor.Blue,
                IOrc => ConsoleColor.Green,
                _ => Console.ForegroundColor
            };
            Console.WriteLine($"{hero.GetType().Name}: health = {hero.Health}, damage = {hero.Damage}");
            Console.ResetColor();
        }

        private static Hero CreateHero(string selectHero, string selectRace)
        {
            return selectHero switch
            {
                "1" => selectRace switch
                {
                    "1" => new MageHuman(),
                    "2" => new MageOrc(),
                    _ => null
                },
                "2" => selectRace switch
                {
                    "1" => new BarbarianHuman(),
                    "2" => new BarbarianOrc(),
                    _ => null
                },
                "3" => selectRace switch
                {
                    "1" => new ArcherHuman(),
                    "2" => new ArcherOrc(),
                    _ => null
                },
                _ => null
            };
        }
    }
}