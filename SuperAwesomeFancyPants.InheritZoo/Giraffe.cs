using System;

namespace SuperAwesomeFancyPants.InheritZoo
{
    public class Giraffe : Mammal
    {
        public Giraffe(int weight)
        {
            Name = "Giraffe";
            NumberOfLegs = 4;
            Weight = weight;
        }

        public override void Eat()
        {
            Console.WriteLine("Eating some 'trees'");
        }

        public override void MakeSound()
        {
            Console.WriteLine("uhm");
        }
    }
}