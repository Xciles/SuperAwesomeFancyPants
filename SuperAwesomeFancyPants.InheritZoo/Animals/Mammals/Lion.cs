using System;
using SuperAwesomeFancyPants.InheritZoo.Animals.Interfaces;

namespace SuperAwesomeFancyPants.InheritZoo.Animals.Mammals
{
    public class Lion : Mammal, IHerbivore
    {
        public Lion(int weight) 
            : base(weight, "Lion")
        {
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