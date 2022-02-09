using System;

namespace moreOOP
{
    public class Wizard : Character, ICastMagic
    {
        public int mana {get;set;}
        public Wizard(string n, string w) : base(n, 80, 10, 18, w, "cloth")
        {
            mana = 250;
        }
        public void castSpell(string move)
        {
            Console.WriteLine($"{name} casts {move}!");
        }
    }
}