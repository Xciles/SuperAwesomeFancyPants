using System;

namespace SuperAwesomeFancyPants.InheritZoo.Animals
{
    public class Crocodile : Reptile
    {
        public Crocodile(int weight)
        {
            Name = "Crocodile";
            NumberOfLegs = 4;
            Weight = weight;
            MaxNumberOfEggs = 1;
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