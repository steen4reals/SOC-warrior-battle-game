using System;

namespace WarriorBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FIGHT!");

            Warrior warrior1 = new Warrior("Fred", 15, 2, 6);
            Warrior warrior2 = new Warrior("Tom", 20, 4, 2);

            HandleAttack(warrior1, warrior2);
            Console.WriteLine(warrior1.Health);
            Console.WriteLine(warrior2.Health);


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



    }
}
