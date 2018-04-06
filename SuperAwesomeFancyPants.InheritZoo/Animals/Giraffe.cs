using System;

namespace SuperAwesomeFancyPants.InheritZoo.Animals
{
    public class Giraffe : Mammal, IHerbivore
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