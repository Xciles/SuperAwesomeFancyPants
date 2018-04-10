using System;

namespace SuperAwesomeFancyPants.InheritZoo.Animals.Reptiles
{
    public class Crocodile : Reptile
    {
        public Crocodile(int weight)
            : base(weight, "Crocodile")
        {
            NumberOfLegs = 4;
        }

        public override void Eat()
        {
            Console.WriteLine("Eating some 'Lion'");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Blub");
        }
    }
}