using System;

namespace SuperAwesomeFancyPants.InheritZoo.Animals
{
    public class Dog : Mammal
    {
        public Dog(int weight)
        {
            Name = "This is Dog!?";
            NumberOfLegs = 4;
            Weight = weight;
            MaxNumberOfChildernInWomb = 10;
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