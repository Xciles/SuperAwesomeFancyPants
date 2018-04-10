using System;
using SuperAwesomeFancyPants.InheritZoo.Animals.Interfaces;

namespace SuperAwesomeFancyPants.InheritZoo.Animals.Mammals
{
    public class Giraffe : Mammal, IHerbivore
    {
        public Giraffe(int weight)
            : base (weight, "Giraffe")
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Eating some 'trees'");
            EatGrass();
        }

        public override void MakeSound()
        {
            Console.WriteLine("uhm");
        }

        public void EatGrass()
        {
            
        }
    }
}