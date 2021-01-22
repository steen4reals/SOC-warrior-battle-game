using System;

namespace WarriorBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FIGHT!");

            Warrior warriorA = new Warrior("Fred", 100, 25, 20);
            Warrior warriorB = new Warrior("Tom", 100, 12, 10);

            //HandleAttack(warriorA, warriorB);
            //Console.WriteLine(warriorA.Health);
            // Console.WriteLine(warriorB.Health);
            Battle(warriorA, warriorB);

            Console.WriteLine($"end of game : warrior A health {warriorA.Health} warrior B health {warriorB.Health}");



        }
        static void HandleAttack(Warrior warrior1, Warrior warrior2)
        {
            int warriorAattack = warrior1.GetAttack();
            int warriorBblock = warrior2.GetBlock();
            int warriorBdamage = warriorAattack - warriorBblock;
            if (warriorBdamage > 0)
            {
                warrior2.ApplyDamage(warriorBdamage);
            }
            Console.WriteLine($" warrior 1 health {warrior1.Health}");
            Console.WriteLine($" warrior 2 health {warrior2.Health}");

        }

        static void Battle(Warrior warriorA, Warrior warriorB)
        {
            Console.WriteLine($"Thus begins a battle of two great warriors; {warriorA.Name} and {warriorB.Name}");
            Console.WriteLine($"{warriorA.Name} has 100 health");
            Console.WriteLine($"{warriorB.Name} has 100 health");
            while (true)
            {

                HandleAttack(warriorA, warriorB);
                if (warriorB.Health < 0)
                {
                    break;
                }
                HandleAttack(warriorB, warriorA);
                if (warriorA.Health < 0)
                {
                    break;
                }
            }
        }

    }
}
