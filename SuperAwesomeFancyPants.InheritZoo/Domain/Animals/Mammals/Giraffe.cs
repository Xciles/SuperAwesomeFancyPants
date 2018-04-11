using System;
using SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Interfaces;
using SuperAwesomeFancyPants.InheritZoo.Domain.Food.Interfaces;

namespace SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Mammals
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
            base.GetFoodAndEat<IPlant>();
        }
    }
}