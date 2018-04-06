using System;

namespace SuperAwesomeFancyPants.InheritZoo.Animals
{
    public class Lion : Mammal, IHerbivore
    {
        public Lion(int weight)
        {
            Name = "Lion";
            NumberOfLegs = 4;
            Weight = weight;
        }

        public override void Eat()
        { 
            EatGrass();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Rawrrrrrrrrr");
            SomeMethodInAnimal();
        }

        public void EatGrass()
        {
            Console.WriteLine("Eating some 'grass'");
        }
    }
}