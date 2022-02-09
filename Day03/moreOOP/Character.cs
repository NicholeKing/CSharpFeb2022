using System;

namespace moreOOP
{
    public abstract class Character
    {
        public string name;
        public int health;
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
    }
}