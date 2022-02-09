using System;

namespace moreOOP
{
    public abstract class Character
    {
        public string name;
        private int health;
        public int Health {get{return health;}}
        public int strength;
        public int intelligence;
        public string weapon;
        public string armorClass;

        public Character(string n, int h, int str, int intel, string w, string ac)
        {
            name = n;
            health = h;
            strength = str;
            intelligence = intel;
            weapon = w;
            armorClass = ac;
        }

        public void changeHealth(int amount)
        {
            this.health += amount;
        }
    }
}