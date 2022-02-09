using System;

namespace moreOOP
{
    public class Warrior : Character
    {
        public int fury;
        public Warrior(string n, string w) : base(n, 120, 16, 7, w, "mail")
        {
            fury = 50;
        }
    }
}