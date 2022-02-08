using System;

namespace classDemo
{
    public class Animal
    {
        // These are fields
        public string species;
        public string diet;
        public bool isExtinct;
        public int avgLifespan;
        public double weight;

        // multiple constructors!
        public Animal(string sp, string d, bool ext, int ls, double wgt)
        {
            species = sp;
            diet = d;
            isExtinct = ext;
            avgLifespan = ls;
            weight = wgt;
        }

        public Animal(string sp, string d, int ls, double wgt)
        {
            species = sp;
            diet = d;
            isExtinct = true;
            avgLifespan = ls;
            weight = wgt;
        }

        public Animal(string sp, string d, bool ext, double wgt)
        {
            species = sp;
            diet = d;
            isExtinct = ext;
            avgLifespan = 20;
            weight = wgt;
        }

        // Methods within classes
        public void makeNoise(string noise)
        {
            Console.WriteLine(noise);
        }

        public virtual void eat()
        {
            Console.WriteLine("Munch munch");
            this.weight+= 0.3;
            Console.WriteLine($"{species} ate some food and now weighs {weight} lbs");
        }
    }
}