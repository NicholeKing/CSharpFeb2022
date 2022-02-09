using System;
using System.Collections.Generic;

namespace moreOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Frog = new Wizard("Frog", "Lily pad shield");
            Console.WriteLine(Frog.mana);
            Warrior Ruben = new Warrior("Ruben", "Battle Axe");
            Console.WriteLine(Ruben.weapon);
            Necromancer Paul = new Necromancer("Paul", "broncosaurus");
            Console.WriteLine(Paul.intelligence);

            List<Character> allCharacters = new List<Character>();

            allCharacters.Add(Frog);
            allCharacters.Add(Ruben);
            allCharacters.Add(Paul);

            List<ICastMagic> allMagicUsers = new List<ICastMagic>();
            foreach(Character c in allCharacters)
            {
                if(c is ICastMagic)
                {
                    allMagicUsers.Add((ICastMagic)c);
                }
            }

            Console.WriteLine("All magic users:");

            foreach(Character a in allMagicUsers)
            {
                Console.WriteLine(a.name);
            }

            Paul.mana += 1000;
            Console.WriteLine(Paul.mana);

            Frog.changeHealth(-20);
            Console.WriteLine(Frog.Health);
            Frog.changeHealth(10000);
            Console.WriteLine(Frog.Health);
        }
    }
}
