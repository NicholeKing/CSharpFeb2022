using System;

namespace classDemo
{
    public class Dinosaur : Animal
    {
        public string period;
        public Dinosaur(string sp, string d, int ls, double w, string hp) : base(sp, d, ls, w)
        {
            period = hp;
        }

        public void makeNoise()
        {
            Console.WriteLine("RAWR");
        }
    }
}