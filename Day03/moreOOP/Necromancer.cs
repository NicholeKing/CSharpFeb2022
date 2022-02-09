using System;

namespace moreOOP
{
    public class Necromancer : Character, ICastMagic
    {
        public int mana {get;set;}
        public Necromancer(string n, string w) : base(n, 90, 8, 16, w, "cloth")
        {
            mana = 300;
        }

        public void castSpell(string move)
        {
            Console.WriteLine($"{name} casts {move}!");
        }
    }
}