using System;

namespace WarriorBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FIGHT!");

            Warrior warrior1 = new Warrior("Fred", 100, 15, 10);
            Warrior warrior2 = new Warrior("Tom", 100, 15, 10);

            //HandleAttack(warriorA, warriorB);
            //Console.WriteLine(warriorA.Health);
            // Console.WriteLine(warriunorB.Health);
            Battle(warrior1, warrior2);

            Console.WriteLine($"end of game : warrior A health {warrior1.Health} warrior B health {warrior2.Health}");

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

        static void Battle(Warrior warrior1, Warrior warrior2)
        {
            Console.WriteLine($"Thus begins a battle of two great warriors; {warrior1.Name} and {warrior2.Name}");
            Console.WriteLine($"{warrior1.Name} has 100 health");
            Console.WriteLine($"{warrior2.Name} has 100 health");
            while (true)
            {

                HandleAttack(warrior1, warrior2);
                Console.WriteLine($" warrior 1 health {warrior1.Health}");
                Console.WriteLine($" warrior 2 health {warrior2.Health}");
                if (warrior2.Health < 0)
                {
                    break;
                }
                HandleAttack(warrior2, warrior1);
                Console.WriteLine($" warrior 1 health {warrior1.Health}");
                Console.WriteLine($" warrior 2 health {warrior2.Health}");
                if (warrior1.Health < 0)
                {
                    break;
                }
            }
        }

    }
}
