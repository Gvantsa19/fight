using System;

namespace fight
{
    public class Bandit : Enemy
    {
        public Bandit(string _name, int _attack, int _health)
            : base(_name, _attack, _health)
        {
            numOfAttack = 2;
        }

        //  Battle methods ---------------------------------------------

        public void Steal(Hero target)
        {
            target.health -= attack + 2;
        }

        public void BanditTurn(int choice, Hero target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("Bandit whacked you!");

            }

            if (choice == 2)
            {
                Steal(target);
                Console.WriteLine("Bandit stole from you!");

            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
