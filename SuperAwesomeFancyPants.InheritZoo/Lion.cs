using System;

namespace SuperAwesomeFancyPants.InheritZoo
{
    public class Lion : Mammal
    {
        public Lion(int weight)
        {
            Name = "Lion";
            NumberOfLegs = 4;
            Weight = weight;
        }

        public override void Eat()
        {
            Console.WriteLine("Eating some 'Giraffe'");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Rawrrrrrrrrr");
        }
    }
}