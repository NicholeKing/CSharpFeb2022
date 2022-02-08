using System;

namespace classDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal liger = new Animal("Liger", "carnivore", false, 20, 500);
            Console.WriteLine(liger.species);

            Dinosaur dino = new Dinosaur("Quetzalcoatlus", "omnivore", 20, 405.2, "Cretaceous");
            Console.WriteLine(dino.period);
            dino.makeNoise();

            Animal dino2 = new Animal("Broncosaurus", "omnivore", true, 405.2);
            Console.WriteLine(dino2.isExtinct);

            Animal pegasus = new Animal("Pegasus", "herbivore", false, 20, 102.3);

            dino.makeNoise("SCREEEEEECH!!");
            pegasus.makeNoise("Neigh!");

            dino.eat();
            liger.eat();
            pegasus.makeNoise($"{dino.species}");

            Mythical phoenix = new Mythical("Phoenix", "Fire", 100000, 120.6, "Egypt", true);

            Console.WriteLine(phoenix.species);
            phoenix.makeNoise("Skraw!");
            phoenix.eat();
        }
    }
}
