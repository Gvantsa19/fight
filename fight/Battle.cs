using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight
{
    class Battle
    {
        public static void IsHeroDead(Hero hero)
        {
            if (hero.health <= 0)
            {
                Console.Clear();
                Console.WriteLine("Looks like you are dead!");
                Console.WriteLine("Better luck next time!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public static void PrintTheStats(Person person1, Person person2)
        {
            person1.PrintStats();
            Console.WriteLine("");
            person2.PrintStats();
            Console.WriteLine("");
        }

        public static void WithBandit(Hero hero, Bandit bandit)
        {
            while (bandit.health > 0 && hero.health > 0)
            {
                PrintTheStats(bandit, hero);

                hero.YourTurn(hero.Choice(), bandit);

                if (bandit.health > 0)
                {
                    bandit.BanditTurn(bandit.EChoice(), hero);
                    IsHeroDead(hero);
                }

            }

            Console.WriteLine($"{bandit.name} was killed!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithKnight(Hero hero, Knight knight)
        {
            while (knight.health > 0 && hero.health > 0)
            {
                PrintTheStats(knight, hero);

                hero.YourTurn(hero.Choice(), knight);

                if (knight.health > 0)
                {
                    knight.KnightTurn(knight.EChoice(), hero);
                    IsHeroDead(hero);
                }
            }

            Console.WriteLine($"{knight.name} was killed!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithDragon(Hero hero, Dragon dragon)
        {
            while (dragon.health > 0 && hero.health > 0)
            {
                PrintTheStats(dragon, hero);

                hero.YourTurn(hero.Choice(), dragon);

                if (dragon.health > 0)
                {
                    dragon.DragonTurn(dragon.EChoice(), hero);
                    IsHeroDead(hero);
                }
            }

            Console.WriteLine($"{dragon.name} was killed !");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
