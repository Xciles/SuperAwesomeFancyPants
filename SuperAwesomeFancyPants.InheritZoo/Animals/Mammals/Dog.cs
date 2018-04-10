using System;

namespace SuperAwesomeFancyPants.InheritZoo.Animals.Mammals
{
    public class Dog : Mammal
    {
        public Dog(int weight)
            : base (weight, "Yes, this is Dog?")
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Eating some 'brokjes'");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woef");
        }
    }
}