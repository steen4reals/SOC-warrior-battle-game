using System;

namespace WarriorBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FIGHT!");

            Warrior warriorA = new Warrior("Fred", 15, 2, 6);
            Warrior warriorB = new Warrior("Tom", 20, 4, 2);

            HandleAttack(warriorA, warriorB);
            Console.WriteLine(warriorA.Health);
            Console.WriteLine(warriorB.Health);


        }
        static void HandleAttack(Warrior warriorA, Warrior warriorB)
        {
            int warriorAattack = warriorA.GetAttack();
            int warriorBblock = warriorB.GetBlock();
            int warriorBdamage = warriorAattack - warriorBblock;
            if (warriorBdamage > 0)
            {
                warriorB.ApplyDamage(warriorBdamage);
            }
        }

        static void Battle(Warrior warrior1, Warrior warrior2){
            while (warrior1.Health>0){
                HandleAttack();
            }
        }

    }
}
