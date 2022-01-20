using System;

namespace fight
{
    public class Knight : Enemy
    {
        public Knight(string _name, int _attack, int _health)
            : base(_name, _attack, _health)
        {
            numOfAttack = 3;
        }

        

        public void Slash(Hero target)
        {
            target.health -= attack + 5;
        }

        public void SheildSlam(Hero target)
        {
            target.health -= attack + 2;
        }

        public void KnightTurn(int choice, Hero target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("Knight punched you!");
            }

            if (choice == 2)
            {
                Slash(target);
                Console.WriteLine("Knight slashed you!");
            }

            if (choice == 3)
            {
                SheildSlam(target);
                Console.WriteLine("Knight slammed you with his shield!");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
